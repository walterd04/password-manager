import Vue from 'vue'; 

export const actions = {

    signUp: (context, payload) => {
        return new Promise(resolve => {
            Vue.http.post('api/Users', payload).then(response => {

                resolve(response);
            }, (response) => {

                resolve(response);
            });
        });
    }, 

    login: (context, payload) => {
        return new Promise(resolve => {
            Vue.http.get('api/Users/' + payload.username + '/' + payload.password).then(response => {

                resolve(response);
            }, (response) => {

                resolve(response);
            });
        });
    }

}