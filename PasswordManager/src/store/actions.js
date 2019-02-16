import Vue from 'vue'; 

export const actions = {

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
            }, (response) => {
                resolve(response);
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
    }

}