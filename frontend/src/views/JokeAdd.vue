<template>
    <div id="jokes-edit">
        <h1>Add a joke:</h1>
        <br>
        <div class="loaded">
            <br>
            <form>
                <input type="text" class="form-control" name="questionInput" id="questionInput" v-model="form.question" placeholder="Enter what you want the question to be"/>
                <br>
                <input type="text" class="form-control" name="answerInput" id="answerInput" v-model="form.answer" placeholder="Enter what you want the answer to be"/>
                <br>
                <input v-if="!sending" type="button" class="form-control" name="submitButton" id="submitButton" @click="submit()" value="Edit Joke"/>
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
            sending: false,
        }
    },

    methods: {
        async submit () {
            this.sending = true;
            await JokesRepository.add({
                jokeId: 0,
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