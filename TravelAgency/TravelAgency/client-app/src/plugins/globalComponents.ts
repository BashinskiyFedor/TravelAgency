import HelloWorld from '../components/HelloWorld.vue'
import Sidebar from '../components/sidebar/sidebar.vue'
import SidebarItem from '../components/sidebar/sidebarItem.vue'
import DashboardNavbar from '../components/navbar/DashboardNavbar.vue'
import BaseNav from '../components/baseElement/BaseNav.vue'
import BaseInput from '../components/input/baseinput.vue'
import CustomArticle from '../components/articles/article.vue'
import rightBar from '../components/rightBar/rightBar.vue'

export default {
  install (Vue: Vue.VueConstructor) {
    Vue.component(HelloWorld.name, HelloWorld)
    Vue.component(Sidebar.name, Sidebar)
    Vue.component(SidebarItem.name, SidebarItem)
    Vue.component(DashboardNavbar.name, DashboardNavbar)
    Vue.component(BaseNav.name, BaseNav)
    Vue.component(BaseInput.name, BaseInput)
    Vue.component(CustomArticle.name, CustomArticle)
    Vue.component(rightBar.name, rightBar)
  }
}
