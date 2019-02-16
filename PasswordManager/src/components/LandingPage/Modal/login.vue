<template>
    <div>
        <div class="modal-header bg-dark text-white">
            <h5 class="modal-title">Login Here!</h5>
            <button type="button" class="close" @click="closeModal()" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>
        <div class="modal-body">
            <div class="help-block text-danger" v-if="showError">Username or password is wrong.</div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="txt-username">Username:</label>
                        <input type="text" class="form-control" id="txt-username" v-model="user.username" />
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="txt-phone">Password:</label>
                        <input type="password" class="form-control" id="txt-password" v-model="user.password" />
                    </div>
                </div>
            </div>
        </div>
        <div class="modal-footer bg-dark text-white">
            <button type="button" class="btn btn-primary" @click.prevent="login()">Login</button>
            <button type="button" class="btn btn-secondary" @click.prevent="closeModal()">Cancel</button>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'login-modal',
        data() {
            return {
                user: {
                    username: '', 
                    password: '', //TODO: encrypt this immediately
                }, 
                showError: false
            };
        },
        methods: {
            login() {
                this.showError = false;
                this.$store.dispatch('login', this.user).then(response => {
                    if (!response) {
                        this.showError = true;
                    }
                });
            },
            closeModal() {
                this.$store.commit('HIDE_MODAL');
            }
        }
    }
</script>

<style scoped>
    .text-red { 
        color: red;
    }
</style>