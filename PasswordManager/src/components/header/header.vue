<template>
    <div>
        <main-menu></main-menu>
    </div>
</template>

<script>
    import Menu from './menu.vue';

    export default {
        name: 'page-header', 
        components: {
            mainMenu: Menu, 
        }
    }
</script>