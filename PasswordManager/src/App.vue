<template>
    <div id="app">
        <header-component></header-component>
    </div>
</template>

<script>
    import Header from './components/Header/header.vue';

    export default {
        name: 'app',
        components: {
           headerComponent: Header 
        }
    };
</script>

<style>
</style>
