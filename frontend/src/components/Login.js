import React, { useState } from 'react';

const API_BASE = process.env.REACT_APP_API_URL || "/api";

function Login() {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [msg, setMsg] = useState('');

  const handleLogin = async (e) => {
    e.preventDefault();
    setMsg('');

    try {
      const res = await fetch(`${API_BASE}/Auth/login`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ username, password })
      });
      if (res.ok) {
        const data = await res.json();
        localStorage.setItem('token', data.token);
        setMsg('Login feito com sucesso!');
        window.location.href = "/dashboard";
      } else {
        setMsg('Login inválido.');
      }
    } catch (err) {
      setMsg('Erro ao ligar ao backend.');
    }
  };

  return (
    <form onSubmit={handleLogin}>
      <h2>Login</h2>
      <input
        type="text"
        placeholder="Username"
        value={username}
        onChange={e => setUsername(e.target.value)}
        required
      /><br />
      <input
        type="password"
        placeholder="Password"
        value={password}
        onChange={e => setPassword(e.target.value)}
        required
      /><br />
      <button type="submit">Entrar</button>
      <div>{msg}</div>
    </form>
  );
}

export default Login;
