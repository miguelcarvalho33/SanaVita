// src/api.js

const API_BASE = process.env.REACT_APP_API_URL || "/api";

export async function apiGet(path, token) {
  const res = await fetch(`${API_BASE}/${path}`, {
    headers: { 'Authorization': 'Bearer ' + token }
  });
  return res.json();
}
