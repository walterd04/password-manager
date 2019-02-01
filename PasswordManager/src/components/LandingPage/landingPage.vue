<template>
    <div>
        <jumbo-tron v-on:sign-up="signUp()"
                    v-on:log-in="login()"></jumbo-tron> 
        <custom-modal v-if="showModal"
                      :type="type"></custom-modal>
        
    </div>
</template>

<script>
    import Jumbotron from './jumbotron.vue';
    import Modal from './Modal/modal.vue';

    export default {
        name: 'landing-page',
        data() {
            return {
                type: 'signup'
            };
        },
        methods: {
            signUp() {
                this.type = 'signup';
                this.$store.commit('SHOW_MODAL');
            },
            login() {
                this.type = 'login'; 
                this.$store.commit('SHOW_MODAL');
            }
        },
        computed: {
            showModal() {
                return this.$store.state.showModal;
            }
        },
        components: {
            jumboTron: Jumbotron, 
            customModal: Modal
        }
    }
</script>