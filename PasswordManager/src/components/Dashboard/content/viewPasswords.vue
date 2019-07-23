<template>
    <div>
        <div class="row" v-if="passwords.length > 0">
            <h1>Coming Soon</h1>
        </div>
        <div class="row" v-else>
            <empty-state button-text="Add a Password Now!"
                         title-text="Oops! It looks like you don't have any passwords yet!"
                         help-text="Don't worry, click the button below to add your first password! We'll even 
                         walk you through it if you want!"
                         @button-click="emptyButtonClick()"></empty-state>
        </div>
    </div>
</template>

<script>
    import EmptyState from '../../elements/emptyState.vue';

    export default {
        computed: {
            passwords() {
                return this.$store.state.passwords;
            }
        }, 
        methods: {
            emptyButtonClick() {   
                this.$emit('set-tab', 'add-password');
            }
        },
        mounted() {
            this.$store.dispatch('getPasswords', this.user.userId);
        },
        computed: {
            user() {
                return this.$store.state.user; 
            }, 
            passwords() {
                return this.$store.state.passwords;
            }
        },
        components: {
            emptyState: EmptyState
        }
    }
</script>

<style scoped>
</style>