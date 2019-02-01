<template>
    <div>
        <jumbo-tron></jumbo-tron>        
    </div>
</template>

<script>
    import Jumbotron from './jumbotron.vue';
    export default {
        name: 'landing-page',
        components: {
            jumboTron: Jumbotron
        }
    }
</script>