import Repository from "./Repository";

const resource = 'Joke';

export default{
    get(){
        return Repository.get(`${resource}`);
    }
}