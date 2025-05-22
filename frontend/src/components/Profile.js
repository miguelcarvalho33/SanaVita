import React, { useEffect, useState } from 'react';
import { apiGet } from '../api';

function Profile() {
  const [user, setUser] = useState(null);
  const [msg, setMsg] = useState('');

  useEffect(() => {
    const token = localStorage.getItem('token');
    apiGet("User/me", token)
      .then(data => setUser(data))
      .catch(() => setMsg("Erro ao carregar perfil."));
  }, []);

  if (msg) return <div style={{ color: 'red' }}>{msg}</div>;
  if (!user) return <div>A carregar perfil...</div>;

  return (
    <div>
      <h2>O meu perfil</h2>
      <p><b>Username:</b> {user.username}</p>
      <p><b>Email:</b> {user.email}</p>
      <p><b>Role:</b> {user.role}</p>
    </div>
  );
}

export default Profile;
