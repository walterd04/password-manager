<template>
    <div>
        <div class="row">
            <div class="col-6">
                <div class="form">
                    <div class="row row-margin-sm">
                        <div class="col-10">
                            <label>Select Engine:</label>
                            <select class="form-control" id="ddl-engine" v-model="engine">
                                <option value="" selected>What Password Are We Saving?</option>
                                <option value="Facebook">Facebook</option>
                                <option value="Twitter">Twitter</option>
                                <option value="LinkedIn">LinkedIn</option>
                                <option value="Instagram">Instagram</option>
                                <option value="Snapchat">SnapChat</option>
                                <option value="Other">Other</option>
                            </select>
                        </div>
                    </div>
                    <div class="row row-margin-md" v-if="engine == 'Other'">
                        <div class="col-10">
                            <label for="txt-engine">What are we saving?</label>
                            <input type="text" class="form-control" @change.prevent="setEngine($event)" id="txt-engine" />
                        </div>
                    </div>
                    <div class="row row-margin-md">
                        <div class="col-5">
                            <label for="txt-password">Password to Save:</label>
                            <input type="password" class="form-control" v-model="password" id="txt-password" />
                        </div>
                        <div class="col-5">
                            <label for="txt-password-secure">Just to be Safe:</label>
                            <input type="password" class="form-control" v-model="passwordSecure" id="txt-password-secure" />
                        </div>
                    </div>
                    <div class="row row-margin-lg">
                        <div class="col-5">
                            <div class="form-check">
                                <input class="form-check-input" type="checkbox" value="true" v-model="changeReminder" id="reminder-check">
                                <label class="form-check-label" for="reminder-check">
                                    Remind me to Change this Password!
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <button type="button" class="btn btn-primary btn-lg btn-block" @click="addPassword()">Submit</button>
                        </div>
                        <div class="col">
                            <button type="button" class="btn btn-danger btn-lg btn-block" @click="resetForm()">Reset</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6">
                <div class="card">

                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                engine: '', 
                password: '', //TODO: encrypt password immediately
                passwordSecure: '', //TODO: encrypt password immediately
                changeReminder: false
            }
        },
        methods: {
            setEngine(text) {
                this.engine = text;
            }, 
            addPassword() {
                var _data = {
                    userId: this.user.userId,
                    engine: this.engine,
                    password: this.password,
                    changeReminder: this.changeReminder
                }; 

                if (_data.password === this.passwordSecure) {
                    this.$store.dispatch('addNewPassword', _data).then(response => {
                        if (response) {
                            this.$store.dispatch('getPasswords', this.user.userId).then(response => {
                                // do something
                            });
                        } else {
                            //
                        }
                    });
                } else {
                    // show error
                }
                //TODO: submit the password if the passwords match and no password matching the engine is present
            }, 
            resetForm() {
                this.engine = ''; 
                this.password = ''; 
                this.passwordSecure = ''; 
                this.changeReminder = false;
            }
        },
        computed: {
            user() {
                return this.$store.state.user;
            }, 
            passwords() {
                return this.$store.state.passwords;
            }
        }
    }
</script>

<style scoped>
</style>