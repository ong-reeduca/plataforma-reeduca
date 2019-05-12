import axios from 'axios';

const instance = axios.create({
    baseUrl: 'http://url'
});

export default instance;