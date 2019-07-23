<template>
    <div class="container">
        <div id="dashboard-main">
            <div class="row">
                <div class="col-3">
                    <dashboard-menu :open-tab="activeItem"
                                    @set-tab="setTab($event)"></dashboard-menu>
                </div>
                <div class="col">
                    <content-view :open-tab="activeItem"
                                  @set-tab="setTab($event)"></content-view>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import ContentView from './content.vue'; 
    import DashboardMenu from './menu.vue';

    export default {
        data() {
            return {
                activeItem: 'view-passwords'
            };
        },
        methods: {
            setTab(tab) {
                this.activeItem = tab;
            }
        },
        components: {
            contentView: ContentView, 
            dashboardMenu: DashboardMenu
        }
    }
</script>

<style scoped>

</style>