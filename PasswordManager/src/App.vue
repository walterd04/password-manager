<template>
    <div id="app">
        <div v-if="!user.isLoggedIn">
            <header-component></header-component>
            <landing-page></landing-page>
        </div>
        <div v-else>
            <menu-component></menu-component>
            <dash-board></dash-board>
        </div>
    </div>
</template>

<script>
    import Header from './components/header/header.vue';
    import LandingPage from './components/LandingPage/landingPage.vue';
    import MenuComponent from './components/header/menu.vue';
    import DashBoard from './components/Dashboard/dashboard.vue';

    export default {
        name: 'app',
        computed: {
            user() {
                return this.$store.state.user;
            }
        },
        components: {
            headerComponent: Header, 
            landingPage: LandingPage, 
            menuComponent: MenuComponent, 
            dashBoard: DashBoard
        }
    };
</script>

<style>
</style>
