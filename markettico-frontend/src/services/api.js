import axios from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:5000/api' // ajusta seg�n tu puerto y ruta
});

export default api;
