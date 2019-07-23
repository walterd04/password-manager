import Vue from 'vue'; 

export const actions = {

    /**** Users Actions ****/
    getUsers: () => {
        return new Promise(resolve => {
            Vue.http.get('Users').then(response => {

                resolve(response);
            });
        });
    },

    signUp: (context, payload) => {
        return new Promise(resolve => {
            Vue.http.post('Users', payload).then(response => {
                resolve(response.body);
            }, () => {
                resolve(false);
            });
        });
    }, 

    login: (context, payload) => {
        return new Promise(resolve => {
            Vue.http.get('Users/' + payload.username + '/' + payload.password).then(response => {
                if (response.body && response.body.length > 0) {
                    context.commit('SET_USER', response);
                    resolve(true);
                } else {
                    resolve(false);
                }
            }, (response) => {

                resolve(response);
            });
        });
    },
    /**** Users Actions ****/

    /**** Password Actions ****/

    getPasswords: (context, payload) => {
        return new Promise(resolve => {
            Vue.http.get('PasswordManagers/' + payload).then(response => {
                if (response.body && response.body.length > 0) {
                    context.commit('SET_DOCUMENTS', response.body);
                    resolve(true);
                } else {
                    resolve(false);
                }
            });
        });
    },

    addNewPassword: (context, payload) => {
        return new Promise(resolve => {
            Vue.http.post('PasswordManagers', payload).then(response => {
                resolve(response.body);
            }, () => {
                resolve(false);
            });
        });
    }

    /**** Password Actions ****/

}