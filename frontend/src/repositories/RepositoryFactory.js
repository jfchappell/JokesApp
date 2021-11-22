import JokesRepository from "./JokesRepository";

const repositories = {
    jokes: JokesRepository
}

export const RepositoryFactory = {
    get: name => repositories[name]
};