import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import { FontAwesomeIcon } from './icons'
import 'bootstrap'
import TravelGlobalComponent from '@/plugins/components'

Vue.config.productionTip = false
Vue.use(TravelGlobalComponent)
Vue.component('icon', FontAwesomeIcon)

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
