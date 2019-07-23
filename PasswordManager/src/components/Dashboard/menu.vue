<template>
    <div>
        <aside class="sm-side">
            <div class="user-portion">
                TODO: Add user information here
            </div>

            <ul class="dashboard-nav">
                <li :class="{ active: openTab === 'view-passwords' }">
                    <a href="#" @click.prevent="setTab('view-passwords')">View Passwords</a>
                </li>
                <li :class="{ active: openTab === 'add-password' }">
                    <a href="#" @click.prevent="setTab('add-password')">Add a New Password</a>
                </li>
                <li :class="{ active: openTab === 'manage-passwords' }">
                    <a href="#" @click.prevent="setTab('manage-passwords')">Manage Passwords</a>
                </li>
                <li :class="{ active: openTab === 'password-generator' }">
                    <a href="#" @click.prevent="setTab('password-generator')">Secure Password Generator</a>
                </li>
                <li :class="{ active: openTab === 'account-settings' }">
                    <a href="#" @click.prevent="setTab('account-settings')">Account Settings</a>
                </li>
            </ul>
        </aside>
    </div>
</template>

<script>
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
            }
        }, 
        methods: {
            setTab(tab) {
                this.$emit('set-tab', tab);
            }
        }
    }
</script>

<style scoped>
</style>