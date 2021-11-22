<template>
    <div id="jokes-home">
        <h1>Jokes:</h1>
        <br>
        <h1 class="loading" v-if="loading">loading...</h1>
        <div class="loaded" v-else>
            <table>
                <tr style="background: #ffc0cb">
                    <td style="font-size: 30px; font-weight: bold;">Joke ID</td>
                    <td style="font-size: 30px; font-weight: bold;">Joke Question</td>
                    <td style="font-size: 30px; font-weight: bold;">Joke Answer</td>
                </tr>
                <tr v-for="joke in info" v-bind:key="joke.jokeId">
                    <td style="font-size: 20px;">{{joke.jokeId}}</td>
                    <td style="font-size: 20px;">{{joke.jokeQuestion}}</td>
                    <td style="font-size: 20px;">{{joke.jokeAnswer}}</td>
                </tr>
            </table>
            <br>
        </div>
    </div>
</template>

<script>
import { RepositoryFactory } from './../repositories/RepositoryFactory'
const JokesRepository = RepositoryFactory.get('jokes')

export default {
    data(){
        return {
            info: null,
            loading: true
        }
    },

    created() {
        this.fetch();
    },

    methods: {
        async fetch () {
            const { data } = await JokesRepository.get();
            this.loading = false;
            this.info = data;
        }
    }
}
</script>

<style lang="less" scoped>
table {
    border: 1px solid black;
    border-collapse: collapse;
    margin-left: auto;
    margin-right: auto;
    tr{
        border: 1px solid black;
        td{
            border: 1px solid black;
            padding-left: 10px;
            padding-right: 10px;
        }
    }
}
</style>