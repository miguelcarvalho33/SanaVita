import React, { useEffect, useState } from 'react';
import { apiGet } from '../api';

const API_BASE = process.env.REACT_APP_API_URL || "/api";

function Medications() {
  const [medications, setMedications] = useState([]);
  const [msg, setMsg] = useState('');
  const [novoMed, setNovoMed] = useState({
    nome: "",
    dosagem: "",
    marca: "",
    modelo: "",
    referenceUrl: "",
    atcCodes: ""
  });

  const [editMed, setEditMed] = useState(null); // Para edição

  const token = localStorage.getItem('token');

  // LISTAR (GET)
  const loadMedications = () => {
    apiGet("Produto", token)
      .then(data => setMedications(data))
      .catch(() => setMsg("Erro ao carregar medicamentos"));
  };

  useEffect(() => {
    loadMedications();
    // eslint-disable-next-line
  }, []);

  // ADICIONAR (POST)
  const adicionarMedicamento = async (e) => {
    e.preventDefault();
    const body = { ...novoMed, atcCodes: novoMed.atcCodes.split(",").map(c => c.trim()) };
    try {
      const res = await fetch(`${API_BASE}/Produto`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + token
        },
        body: JSON.stringify(body)
      });
      if (res.ok) {
        setMsg("Medicamento adicionado!");
        setNovoMed({ nome: "", dosagem: "", marca: "", modelo: "", referenceUrl: "", atcCodes: "" });
        loadMedications();
      } else {
        setMsg("Erro ao adicionar medicamento.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  // EDITAR (PUT)
  const iniciarEdicao = (med) => setEditMed({ ...med, atcCodes: med.atcCodes.join(", ") });

  const guardarEdicao = async (e) => {
    e.preventDefault();
    const body = { ...editMed, atcCodes: editMed.atcCodes.split(",").map(c => c.trim()) };
    try {
      const res = await fetch(`${API_BASE}/Produto/${editMed.id}`, {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + token
        },
        body: JSON.stringify(body)
      });
      if (res.ok) {
        setMsg("Medicamento editado!");
        setEditMed(null);
        loadMedications();
      } else {
        setMsg("Erro ao editar medicamento.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  // REMOVER (DELETE)
  const removerMedicamento = async (id) => {
    try {
      const res = await fetch(`${API_BASE}/Produto/${id}`, {
        method: "DELETE",
        headers: { Authorization: "Bearer " + token }
      });
      if (res.ok) {
        setMsg("Medicamento removido!");
        loadMedications();
      } else {
        setMsg("Erro ao remover medicamento.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  // FORMULÁRIOS
  return (
    <div>
      <h2>Medicamentos</h2>
      {msg && <div style={{ color: 'red' }}>{msg}</div>}

      {/* Adicionar novo medicamento */}
      <h3>Adicionar Medicamento</h3>
      <form onSubmit={adicionarMedicamento}>
        <input name="nome" placeholder="Nome" value={novoMed.nome} onChange={e => setNovoMed({ ...novoMed, nome: e.target.value })} required />
        <input name="dosagem" placeholder="Dosagem" value={novoMed.dosagem} onChange={e => setNovoMed({ ...novoMed, dosagem: e.target.value })} required />
        <input name="marca" placeholder="Marca" value={novoMed.marca} onChange={e => setNovoMed({ ...novoMed, marca: e.target.value })} />
        <input name="modelo" placeholder="Modelo" value={novoMed.modelo} onChange={e => setNovoMed({ ...novoMed, modelo: e.target.value })} />
        <input name="referenceUrl" placeholder="URL de referência" value={novoMed.referenceUrl} onChange={e => setNovoMed({ ...novoMed, referenceUrl: e.target.value })} />
        <input name="atcCodes" placeholder="ATC Codes (separado por vírgulas)" value={novoMed.atcCodes} onChange={e => setNovoMed({ ...novoMed, atcCodes: e.target.value })} />
        <button type="submit">Adicionar</button>
      </form>

      <ul>
        {medications.length === 0 && <li>Nenhum medicamento encontrado.</li>}
        {medications.map(med => (
          <li key={med.id}>
            {editMed && editMed.id === med.id ? (
              // Formulário de edição inline
              <form onSubmit={guardarEdicao}>
                <input value={editMed.nome} onChange={e => setEditMed({ ...editMed, nome: e.target.value })} />
                <input value={editMed.dosagem} onChange={e => setEditMed({ ...editMed, dosagem: e.target.value })} />
                <input value={editMed.marca} onChange={e => setEditMed({ ...editMed, marca: e.target.value })} />
                <input value={editMed.modelo} onChange={e => setEditMed({ ...editMed, modelo: e.target.value })} />
                <input value={editMed.referenceUrl} onChange={e => setEditMed({ ...editMed, referenceUrl: e.target.value })} />
                <input value={editMed.atcCodes} onChange={e => setEditMed({ ...editMed, atcCodes: e.target.value })} />
                <button type="submit">Guardar</button>
                <button type="button" onClick={() => setEditMed(null)}>Cancelar</button>
              </form>
            ) : (
              <>
                <b>{med.nome}</b> — {med.dosagem}<br />
                Marca: {med.marca} | Modelo: {med.modelo}<br />
                ATC: {med.atcCodes && med.atcCodes.join(", ")}<br />
                <a href={med.referenceUrl} target="_blank" rel="noreferrer">Ver referência</a><br />
                <button onClick={() => iniciarEdicao(med)}>Editar</button>
                <button onClick={() => removerMedicamento(med.id)}>Remover</button>
                <hr />
              </>
            )}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default Medications;
