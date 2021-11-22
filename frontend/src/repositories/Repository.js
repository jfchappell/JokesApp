import axios from 'axios';

const baseDomain = "https://localhost:5001/api";
const baseURL = `${baseDomain}`;

export default axios.create({
    baseURL
});