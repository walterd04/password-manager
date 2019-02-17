<template>
    <keep-alive>
        <component v-bind:is="openTab"
                   @set-tab="setTab($event)"></component>
    </keep-alive>
</template>

<script>
    import ViewPasswords from './content/viewPasswords.vue'; 
    import AddPassword from './content/addPassword.vue'; 
    import ManagePasswords from './content/managePasswords.vue'; 
    import PasswordGenerator from './content/passwordGenerator.vue';
    import AccountSettings from './content/accountSettings.vue';

    export default {
        props: {
            openTab: {
                type: String, 
                required: true
            }
        },
        data() {
            return {
                //
            };
        }, 
        methods: {
            setTab(tab) {
                this.$emit('set-tab', tab);
            }
        },
        components: {
            viewPasswords: ViewPasswords, 
            addPassword: AddPassword, 
            managePasswords: ManagePasswords, 
            passwordGenerator: PasswordGenerator, 
            accountSettings: AccountSettings
        }
    }
</script>

<style scoped>
</style>