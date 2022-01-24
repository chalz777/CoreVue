<template>
  
    <v-app>
        <v-system-bar app class="text-center" color="red" dark>
            <v-row class="text-center">
                <v-spacer />
                <span class="black--text">
                    This site contains dynamic content - Highest Possible Classification is SECRET
                </span>
            </v-row>
            <v-spacer></v-spacer>
            <v-icon>mdi-wifi-strength-4</v-icon>
            <v-icon>mdi-signal-cellular-outline</v-icon>
            <v-icon>mdi-battery</v-icon>
            <span>12:30</span>
        </v-system-bar>
        
            <v-navigation-drawer app dark>
                <v-list nav>
                    <v-list-item link v-for="item in navItems" :key="item.id" @click="navItem_onclick(item)">
                        <v-list-item-content>
                            <v-list-item-title>
                                <span :class="'mdi mdi-' + item.icon" :style="{'font-size':item.isize + 'px'}"></span>                             
                                {{item.title}}
                            </v-list-item-title>
                        </v-list-item-content>
                    </v-list-item>
                </v-list>
            </v-navigation-drawer>

           
            <v-app-bar app>
                <h2>Surface Ship Radiated Noise Measurement</h2>
                <v-spacer></v-spacer>
                <v-toolbar-items class="hidden-sm-and-down">
                    <v-btn>
                        <span class="mdi mdi-ship-wheel" style="font-size:24px"></span>                    
                        <router-link to="/ssrnm">SSRNM Main</router-link>
                    </v-btn>
                    <v-btn>
                        <span class="mdi mdi-anchor" style="font-size:24px"></span>                        
                        <router-link to="/">Atlantic Fleet</router-link>
                    </v-btn>
                    <v-btn>                      
                        <span class="mdi mdi-account-question" style="font-size:24px"></span>
                        <router-link to="/about">About</router-link>
                    </v-btn>
                </v-toolbar-items>


            </v-app-bar>
            <v-main>
                <v-container fluid>
                    <router-view :parentComponent="currItem" />
                </v-container>
            </v-main>
            <v-footer app>
                <!-- -->
            </v-footer>
</v-app>
</template>

<script lang="ts">
    /* eslint-disable vue/no-unused-components */
    import Vue from 'vue';
    import SsrnmMain from '@/views/SsrnmMain.vue'; 
    

export default Vue.extend({

  name: 'App',
  components: {
      SsrnmMain,   
  },  
    data: () => ({
        navItems: [
            {
                id: 0,
                link: "landing-page",
                icon: "ship-wheel",
                isize: "22",
            title: " - SSRNM Main"
            , header: "ATLANTIC FLEET"
        }, {
            id: 1,
                link: "",
                icon: "anchor",
                isize: "20",
            title: " - ATLANTIC FLEET"
            , header: "ATLANTIC FLEET"
        }, {
            id: 2,
                link: "trials-table",
                icon: "google-assistant",
                isize: "18",
            title: " - TRIAL HISTORY"
            , header: "ATLANTIC FLEET"
        }, {
                id: 3,
                link: "asw-table",
                icon: "google-circles",
                isize: "19",
                title: " - ASW OVERVIEW"
                , header: "ATLANTIC FLEET"
        },{
                id: 4,
                link: "non-asw-table",
                icon: "google-chrome",
                isize: "19",
                title: " - NON ASW OVERVIEW"
                , header: "NON ATLANTIC FLEET"
            
        }, {
                id: 5,
                link: "search-form",
                icon: "briefcase-search",
                isize: "19",
                title: " - SEARCH"
                , header: "SEARCH"
        }, {
                id: 6,
                link: "reports-list",
                icon: "database-plus",
                isize: "19",
                title: " - REPORTS LIST"
                , header: "REPORTS LIST"
        }, {
                id: 7,
                link: "last-15-trials",
                icon: "history",
                isize: "19",
                title: " - LAST 15 TRIALS"
                , header: "LAST 15 TRIALS"
        }, {
                id: 8,
                link: "contacts",
                icon: "account",
                isize: "21",
                title: " - CONTACTS"
                , header: "CONTACTS"
        }, {
                id: 9,
                link: "coming-soon",
                icon: "hammer-wrench",
                isize: "19",
                title: " - COMING SOON"
                , header: "COMING SOON"
        }, {
                id: 10,
                link: "dod-notice",
                icon: "gavel",
                isize: "19",
                title: " - DOD NOTICE"
                , header: "DOD NOTICE"
        },
            //{
        //        id: 5,
        //        link: "reuse-tabs",
        //        icon: "mdi-airplane",
        //        isize: "22",
        //        title: " - reuse-tabs"
        //        , header: "reuse-tabs FLEET"
        // },
        ],
        currItem: '',
    }),
    methods: {
        navItem_onclick(item) {           
            this.currItem = item
        },
    }
});
</script>
