<template>
    <div>
        <main-menu></main-menu>
        <landing-page></landing-page>
    </div>
</template>

<script>
    import Menu from './menu.vue';
    import LandingPage from './LandingPage/landingPage.vue';

    export default {
        name: 'page-header', 
        components: {
            mainMenu: Menu, 
            landingPage: LandingPage
        }
    }
</script>