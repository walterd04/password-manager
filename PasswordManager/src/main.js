import Vue from 'vue';
import App from './App.vue';
import VueResource from 'vue-resource'; 
import Vuex from 'vuex'; 
import VueMaterial from 'vue-material'; 
import 'vue-material/dist/vue-material.min.css';

Vue.use(VueResource); 
Vue.use(Vuex); 
Vue.use(VueMaterial);

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
