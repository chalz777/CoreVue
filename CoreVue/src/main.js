import Vue from 'vue';
import App from './App.vue';
import vuetify from '@/plugins/vuetify' // path to vuetify export
import moment from 'moment'

Vue.config.productionTip = true;
Vue.filter('formatDate', function(value) {
    if (value) {
      return moment(String(value)).format('MM/DD/YYYY hh:mm')
    }
  });

new Vue({
    vuetify,
    render: h => h(App)
}).$mount('#app');
