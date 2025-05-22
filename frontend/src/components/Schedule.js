import React, { useEffect, useState } from 'react';
import { apiGet } from '../api';

const API_BASE = process.env.REACT_APP_API_URL || "/api";

function Schedule() {
  const [schedules, setSchedules] = useState([]);
  const [msg, setMsg] = useState('');
  const [novo, setNovo] = useState({
    produtoNome: "",
    dose: "",
    hora: "",
    dataInicio: "",
    dataFim: ""
  });
  const [edit, setEdit] = useState(null);

  const token = localStorage.getItem('token');

  // LISTAR (GET)
  const loadSchedules = () => {
    apiGet("MedicationSchedule", token)
      .then(data => setSchedules(data))
      .catch(() => setMsg("Erro ao carregar horários/agendamentos."));
  };

  useEffect(() => {
    loadSchedules();
    // eslint-disable-next-line
  }, []);

  // ADICIONAR (POST)
  const adicionar = async (e) => {
    e.preventDefault();
    try {
      const res = await fetch(`${API_BASE}/MedicationSchedule`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + token
        },
        body: JSON.stringify(novo)
      });
      if (res.ok) {
        setMsg("Agendamento adicionado!");
        setNovo({ produtoNome: "", dose: "", hora: "", dataInicio: "", dataFim: "" });
        loadSchedules();
      } else {
        setMsg("Erro ao adicionar agendamento.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  // EDITAR (PUT)
  const iniciarEdicao = (item) => setEdit({ ...item });

  const guardarEdicao = async (e) => {
    e.preventDefault();
    try {
      const res = await fetch(`${API_BASE}/MedicationSchedule/${edit.id}`, {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + token
        },
        body: JSON.stringify(edit)
      });
      if (res.ok) {
        setMsg("Agendamento editado!");
        setEdit(null);
        loadSchedules();
      } else {
        setMsg("Erro ao editar agendamento.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  // REMOVER (DELETE)
  const remover = async (id) => {
    try {
      const res = await fetch(`${API_BASE}/MedicationSchedule/${id}`, {
        method: "DELETE",
        headers: { Authorization: "Bearer " + token }
      });
      if (res.ok) {
        setMsg("Agendamento removido!");
        loadSchedules();
      } else {
        setMsg("Erro ao remover agendamento.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  return (
    <div>
      <h2>Horários / Schedules</h2>
      {msg && <div style={{ color: 'red' }}>{msg}</div>}

      {/* Adicionar agendamento */}
      <h3>Adicionar Agendamento</h3>
      <form onSubmit={adicionar}>
        <input name="produtoNome" placeholder="Medicamento" value={novo.produtoNome} onChange={e => setNovo({ ...novo, produtoNome: e.target.value })} required />
        <input name="dose" placeholder="Dose" value={novo.dose} onChange={e => setNovo({ ...novo, dose: e.target.value })} required />
        <input name="hora" placeholder="Hora (ex: 08:00)" value={novo.hora} onChange={e => setNovo({ ...novo, hora: e.target.value })} required />
        <input name="dataInicio" placeholder="Data Início" type="date" value={novo.dataInicio} onChange={e => setNovo({ ...novo, dataInicio: e.target.value })} required />
        <input name="dataFim" placeholder="Data Fim" type="date" value={novo.dataFim} onChange={e => setNovo({ ...novo, dataFim: e.target.value })} />
        <button type="submit">Adicionar</button>
      </form>

      <ul>
        {schedules.length === 0 && <li>Nenhum agendamento encontrado.</li>}
        {schedules.map(item => (
          <li key={item.id}>
            {edit && edit.id === item.id ? (
              <form onSubmit={guardarEdicao}>
                <input value={edit.produtoNome} onChange={e => setEdit({ ...edit, produtoNome: e.target.value })} />
                <input value={edit.dose} onChange={e => setEdit({ ...edit, dose: e.target.value })} />
                <input value={edit.hora} onChange={e => setEdit({ ...edit, hora: e.target.value })} />
                <input type="date" value={edit.dataInicio} onChange={e => setEdit({ ...edit, dataInicio: e.target.value })} />
                <input type="date" value={edit.dataFim} onChange={e => setEdit({ ...edit, dataFim: e.target.value })} />
                <button type="submit">Guardar</button>
                <button type="button" onClick={() => setEdit(null)}>Cancelar</button>
              </form>
            ) : (
              <>
                <b>{item.produtoNome}</b> — Dose: {item.dose}<br />
                Hora: {item.hora}<br />
                Início: {item.dataInicio} | Fim: {item.dataFim}<br />
                <button onClick={() => iniciarEdicao(item)}>Editar</button>
                <button onClick={() => remover(item.id)}>Remover</button>
                <hr />
              </>
            )}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default Schedule;
