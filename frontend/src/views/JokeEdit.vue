<template>
    <div id="jokes-edit">
        <h1>Edit a joke:</h1>
        <br>
        <h1 class="loading" v-if="loading">loading...</h1>
        <div class="loaded" v-else>
            <br>
            <h3>Editing Joke ID: {{id}}</h3>
            <form>
                <input type="text" class="form-control" name="questionInput" id="questionInput" v-model="form.question" placeholder="Enter what you want the question to be"/>
                <br>
                <input type="text" class="form-control" name="answerInput" id="answerInput" v-model="form.answer" placeholder="Enter what you want the answer to be"/>
                <br>
                <input type="button" class="form-control" name="submitButton" id="submitButton" @click="submit()" value="Edit Joke"/>
            </form>
        </div>
    </div>
</template>

<script>
import { RepositoryFactory } from './../repositories/RepositoryFactory'
const JokesRepository = RepositoryFactory.get('jokes')

export default {
    data(){
        return {
            form:{
                quesiton: '',
                answer: ''
            },
            id: this.$route.params.id,
            sending: false
        }
    },

    created() {
        this.fetch();
    },

    methods: {
        async fetch () {
            const { data } = await JokesRepository.getById(this.id);
            this.loading = false;
            this.form.question = data.jokeQuestion;
            this.form.answer = data.jokeAnswer;
        },
        async submit () {
            await JokesRepository.edit({
                jokeId: this.id,
                jokeQuestion: this.form.question,
                jokeAnswer: this.form.answer
            }).then(() => {
                this.$router.push('/');
            })
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