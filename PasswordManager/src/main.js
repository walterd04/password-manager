import Vue from 'vue';
import App from './App.vue';
import VueResource from 'vue-resource'; 
import Vuex from 'vuex';
import cors from 'cors';
import { store } from './store/store';
import './assets/site.css';
import 'jquery';
import '../node_modules/jquery/dist/jquery.min.js';
import 'bootstrap';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../node_modules/bootstrap/dist/js/bootstrap.min.js';
//import '../node_modules/font-awesome/css/font-awesome.min.css';

Vue.use(VueResource); 
Vue.use(Vuex); 
Vue.use(cors);

Vue.config.productionTip = true;

Vue.http.options.root = 'https://localhost:44322/api/'; 
Vue.http.headers.common['X-Requested-With'] = 'XMLHttpRequest'; 
Vue.http.headers.common['Access-Control-Allow-Origin'] = '*';
Vue.http.headers.common['Access-Control-Allow-Methods'] = 'POST, GET, PUT, OPTIONS, DELETE';
Vue.http.headers.common['Content-Type'] = 'application/json; charset=utf-8';
Vue.http.headers.common['Accept'] = '/';

//Vue.http.interceptors.push((request, next) => {
//    request.headers.set('X-CSRF-TOKEN', 'VERY_SECURE_TOKEN_HERE');
//});

new Vue({
    render: h => h(App), 
    store: store
}).$mount('#app');
