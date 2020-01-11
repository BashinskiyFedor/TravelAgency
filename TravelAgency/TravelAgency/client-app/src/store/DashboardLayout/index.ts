import { Module } from 'vuex'
import { actions } from './actions'
import { mutations } from './mutations'
import { DashboardState } from './tupes'
import { RootState } from '../types'

export const state: DashboardState = {
  sidebarStatic: false
}

const namespaced: boolean = true

export const dashboard: Module<DashboardState, RootState> = {
  namespaced,
  state,
  actions,
  mutations
}
