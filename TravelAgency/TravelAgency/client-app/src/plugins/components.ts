import globalComponents from './globalComponents'
import '@/style/scss/infinity.scss'

export default {
  install (Vue: Vue.VueConstructor) {
    Vue.use(globalComponents)
  }
}
