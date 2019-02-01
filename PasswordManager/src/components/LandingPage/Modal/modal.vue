<template>
    <transition name="modal-fade">
        <div class="modal-mask">
            <div class="modal-wrapper">
                <div class="modal-dialog modal-lg" role="document">
                    <div class="modal-content">
                        <login-modal v-if="type == 'login'"></login-modal>
                        <signup-modal v-if="type == 'signup'"></signup-modal>
                    </div>
                </div>
            </div>
        </div>
    </transition>
</template>

<script>
    import LoginModal from './login.vue'; 
    import SignUpModal from './signup.vue';

    export default {
        name: 'custom-modal', 
        props: {
            type: {
                type: String, 
                required: true
            }
        },
        components: {
            loginModal: LoginModal, 
            signupModal: SignUpModal
        }
    }
</script>

<style scoped>
    .modal-mask {
        position: fixed; 
        z-index: 9999; 
        top: 0; 
        left: 0; 
        width: 100%; 
        height: 100%; 
        background-color: rgba(0, 0, 0, .4); 
        display: table; 
        transition: opacity .3s ease;
    }

    .modal-wrapper {
        display: table-cell;
        vertical-align: middle;
    }

    .modal-fade-enter, 
    .modal-fade-leave-active {
        opacity: 0;
    }

    .modal-fade-enter-active, 
    .modal-fade-leave-active {
        transition: opacity .3s ease;
    }
</style>