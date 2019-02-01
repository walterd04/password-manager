import Vue from 'vue';
import App from './App.vue';
import VueResource from 'vue-resource'; 
import Vuex from 'vuex';
import './assets/site.css';
import 'jquery';
import '../node_modules/jquery/dist/jquery.min.js';
import 'bootstrap';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../node_modules/bootstrap/dist/js/bootstrap.min.js';

Vue.use(VueResource); 
Vue.use(Vuex); 

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
