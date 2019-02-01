<template>
    <div>
        <div class="modal-header">
            <h5 class="modal-title">Sign-Up Free!</h5>
            <button type="button" class="close" @click="closeModal()" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>
        <div class="modal-body">
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="txt-first">First Name:</label>
                        <input type="text" class="form-control" id="txt-first" v-model="user.first" />
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="txt-last">Last Name:</label>
                        <input type="text" class="form-control" id="txt-last" v-model="user.last" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="txt-email">Email Address:</label>
                        <input type="email" class="form-control" id="txt-email" v-model="user.email" />
                        <small class="form-text text-muted">We'll never share your email with anyone else!</small>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="txt-password">Password:</label>
                        <input type="password" class="form-control" id="txt-password" v-model="user.password" />
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="txt-password-secure">Retype Password:</label>
                        <input type="password" class="form-control" id="txt-password-secure" v-model="user.passwordSecure" />
                    </div>
                </div>
            </div>
        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-primary" @click.prevent="signUp()">Complete Sign-Up</button>
            <button type="button" class="btn btn-secondary" @click="closeModal()">Cancel</button>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'signup-modal', 
        data() {
            return {
                user: {
                    first: '',
                    last: '',
                    email: '',
                    password: '', 
                    passwordSecure: ''
                }
            };
        },
        methods: {
            closeModal() {
                this.$store.commit('HIDE_MODAL');
            }, 
            signUp() {
                if (this.user.password === this.user.passwordSecure) {
                    this.$store.dispatch('signUp', this.user).then(response => {
                        this.$store.dispatch('login', response).then(response => {

                        });
                    });
                }
            }
        }
    }
</script>