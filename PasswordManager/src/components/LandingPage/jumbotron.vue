<template>
    <div class="jumbotron jumbotron-fluid bg-warning">       
        <h1 class="display-4 pl-5">Password Manager</h1>
        <p class="lead pl-5">
            Are you always finding yourself trying password after password on every website you sign up for?<br>
            Don't want to pay just to store your passwords safely and securely?<br>
            You've come to the right place! Find out more below!
        </p>
        <hr />
        <div class="pl-5">
            <button type="button" class="btn btn-success btn-lg mr-4" @click="signUp()">Sign Up Now!</button>
            <button type="button" class=" btn btn-primary btn-lg" @click="scrollDown()">Learn More!</button>
            <p class="pl-3 mt-2">
                Already a member?
                <a href="#" @click.prevent="login()">Login here!</a>
            </p>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'jumbo-tron', 
        methods: {
            signUp() {
                this.$emit('sign-up');
            }, 
            scrollDown() {
                this.$emit('scroll-down'); 
            }, 
            login() {
                this.$emit('log-in');
            }
        }
    }
</script>