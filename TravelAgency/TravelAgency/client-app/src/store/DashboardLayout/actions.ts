import { ActionTree } from 'vuex'
import { DashboardState } from './tupes'
import { RootState } from '../types'

export const actions: ActionTree<DashboardState, RootState> = {
  toggleSidebar ({ commit }) {
    commit('toggleSidebar')
  }
}
