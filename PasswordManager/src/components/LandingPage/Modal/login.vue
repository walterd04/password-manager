<template>
    <div>
        <div class="modal-header">
            <h5 class="modal-title">Login Here!</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>
        <div class="modal-body">
            <p>Login form goes here</p>
        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-primary">Login</button>
            <button type="button" class="btn btn-secondary" @click.prevent="closeModal()">Cancel</button>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'login-modal', 
        methods: {
            closeModal() {
                this.$store.commit('CLOSE_MODAL');
            }
        }
    }
</script>