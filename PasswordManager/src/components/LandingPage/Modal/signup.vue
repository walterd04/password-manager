<template>
    <div>
        <div class="modal-header">
            <h5 class="modal-title">Sign-Up Free!</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>
        <div class="modal-body">
            <p>sign-up form goes here</p>
        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-primary">Complete Sign-Up</button>
            <button type="button" class="btn btn-secondary" @click="closeModal()">Cancel</button>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'signup-modal', 
        methods: {
            closeModal() {
                this.$store.commit('HIDE_MODAL');
            }
        }
    }
</script>