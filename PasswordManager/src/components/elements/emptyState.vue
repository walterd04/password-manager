<template>
    <div>
        <div class="col-12">
            <div class="jumbotron">
                <h1 class="d-flex justify-content-center"><i class="fas fa-tools"></i></h1>
                <h3 class="d-flex justify-content-center">{{ titleText }}</h3>
                <p class="d-flexj justify-content-center">{{ helpText }}</p>
                <hr class="pl-5 pr-5" />
                <div class="d-flex justify-content-center" v-if="buttonText">
                    <button type="button" class="btn btn-success btn-lg mr-4" @click.prevent="buttonClick()">{{ buttonText }}</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        props: {
            titleText: {
                type: String, 
                required: true
            },
            buttonText: {
                type: String,
                required: false
            }, 
            helpText: {
                type: String, 
                required: false
            }
        },
        methods: {
            buttonClick() {
                this.$emit('button-click');
            }
        }
    }
</script>

<style scoped>
    .fas.fa-tools { 
        font-size: 100px;
    }
</style>