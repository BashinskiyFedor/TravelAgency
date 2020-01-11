import { MutationTree } from 'vuex'
import { DashboardState } from './tupes'

export const mutations: MutationTree<DashboardState> = {
  toggleSidebar (state) {
    const nextState = !state.sidebarStatic
    state.sidebarStatic = nextState
  }
}
