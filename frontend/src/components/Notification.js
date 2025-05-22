import React, { useEffect, useState } from 'react';
import { apiGet } from '../api';

const API_BASE = process.env.REACT_APP_API_URL || "/api";

function Notifications() {
  const [notifs, setNotifs] = useState([]);
  const [msg, setMsg] = useState('');
  const token = localStorage.getItem('token');

  const loadNotifs = () => {
    apiGet("Notification", token)
      .then(data => setNotifs(data))
      .catch(() => setMsg("Erro ao carregar notificações."));
  };

  useEffect(() => {
    loadNotifs();
    // eslint-disable-next-line
  }, []);

  // Remover notificação (DELETE)
  const removerNotif = async (id) => {
    try {
      const res = await fetch(`${API_BASE}/Notification/${id}`, {
        method: "DELETE",
        headers: { Authorization: "Bearer " + token }
      });
      if (res.ok) {
        setMsg("Notificação removida!");
        loadNotifs();
      } else {
        setMsg("Erro ao remover notificação.");
      }
    } catch (err) {
      setMsg("Erro ao ligar ao backend.");
    }
  };

  return (
    <div>
      <h2>Notificações</h2>
      {msg && <div style={{ color: 'red' }}>{msg}</div>}
      <ul>
        {notifs.length === 0 && <li>Nenhuma notificação encontrada.</li>}
        {notifs.map(n => (
          <li key={n.id}>
            {n.texto} <br />
            <small>{n.data}</small> <br />
            <button onClick={() => removerNotif(n.id)}>Remover</button>
            <hr />
          </li>
        ))}
      </ul>
    </div>
  );
}

export default Notifications;
