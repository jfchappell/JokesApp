import Repository from "./Repository";

const resource = 'Joke';

export default{
    get(){
        return Repository.get(`${resource}`);
    },
    getById(id){
        return Repository.get(`${resource}/` + id);
    },
    add(data){
        return Repository.post(`${resource}`, data);
    },
    edit(data){
        return Repository.put(`${resource}`, data);
    },
    delete(id){
        return Repository.delete(`${resource}/` + id);
    }
}