﻿//import { tabGroup } from '../VueComponents/tab-group.js'
//import { travelerInfo } from '../VueComponents/traveler-info.js'
//import { tripDetail } from '../VueComponents/trip-detail.js'
//import { tripInfo } from '../VueComponents/trip-info.js'
//import { flightDetails } from '../VueComponents/flight-details.js'
//import { tripSummary } from '../VueComponents/trip-summary.js'
//import { vueServer } from '../VueComponents/vue-server.js'


//import { routeInfo } from './route-info.js'
//import { attachmentMain } from './attachment-main.js'
//import { DataAccess } from '../../js/dataAccess.js'
import { PersistRoutedDocumentObject, RoutedDocumentObject, ReviewDetailObject } from '../VueComponents/RoutedDoc.js'

Vue.use(Toasted);
//Vue.use(vueServer);

var router = new VueRouter({
    mode: 'history',
    routes: []
});
window.vm = new Vue({
    vuetify: new Vuetify(),
    router,
    el: '#app',
    components: { routeInfo, attachmentMain },
    data: function () {
        return {
            showSubmit: false,
            isLoading: false,
            isAdmin: false,
            showSave: false
        }
    },
    methods: {
    },
    
    watch: {
    },
    mounted: function () {
        return;
        //var self = this;

        //self.setupValidation();
        //self.canSubmit();
        //DataAccess.getUserIsAdmin().then(function (result) {
        //    self.isAdmin = result;
        //});
    },
    template: `
<v-app id="lasers">
	<v-overlay :value="isLoading" z-index="9999">
		<v-progress-circular indeterminate size="64"></v-progress-circular>
	</v-overlay>

	<div class="route-info mt-5">
		<div class="text-center">
			<h1>Route Correspondence</h1>
		</div>
	
			
	</div>
</v-app>
`
});


