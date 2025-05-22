import React, { useState } from 'react';

const API_BASE = process.env.REACT_APP_API_URL || "/api";

function Register() {
  const [username, setUsername] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [role, setRole] = useState('Patient');
  const [msg, setMsg] = useState('');

  const handleRegister = async (e) => {
    e.preventDefault();
    setMsg('');

    try {
      const res = await fetch(`${API_BASE}/Auth/register`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ username, email, password, role })
      });
      if (res.ok) {
        setMsg('Registo feito com sucesso! Podes agora fazer login.');
      } else {
        const error = await res.text();
        setMsg('Erro no registo: ' + error);
      }
    } catch (err) {
      setMsg('Erro ao ligar ao backend.');
    }
  };

  return (
    <form onSubmit={handleRegister}>
      <h2>Registar</h2>
      <input
        type="text"
        placeholder="Username"
        value={username}
        onChange={e => setUsername(e.target.value)}
        required
      /><br />
      <input
        type="email"
        placeholder="Email"
        value={email}
        onChange={e => setEmail(e.target.value)}
        required
      /><br />
      <input
        type="password"
        placeholder="Password"
        value={password}
        onChange={e => setPassword(e.target.value)}
        required
      /><br />
      <select value={role} onChange={e => setRole(e.target.value)}>
        <option value="Patient">Paciente</option>
        <option value="Caregiver">Cuidador</option>
        <option value="Admin">Administrador</option>
        <option value="Pharmacist">Farmacêutico</option>
      </select><br />
      <button type="submit">Registar</button>
      <div>{msg}</div>
    </form>
  );
}

export default Register;
