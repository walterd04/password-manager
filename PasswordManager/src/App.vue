<template>
    <div id="app">
        <header-component></header-component>
        <landing-page></landing-page>
    </div>
</template>

<script>
    import Header from './components/Header/header.vue';
    import LandingPage from './components/LandingPage/landingPage.vue';

    export default {
        name: 'app',
        components: {
            headerComponent: Header, 
            landingPage: LandingPage
        }
    };
</script>

<style>
</style>
