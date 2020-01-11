<template>
  <div :class="dashboard">
    <sidebar>
      <template slot="links">
        <sidebar-item :link="{name: 'Ighjfgh', icon: 'envelope', path: '/icons'}" />
        <sidebar-item :link="{name: 'Ifhjfh', icon: ['fab', 'vuejs'], path: '/icons'}" />
        <sidebar-item :link="{name: 'Hgdfgh', icon: ['fab', 'microsoft'], path: '/icons'}" />
        <sidebar-item :link="{name: 'DGghdg', icon: ['fas', 'info'], path: '/icons'}" />
        <sidebar-item :link="{name: 'Hdfdghh', icon: ['fas', 'spinner'], path: '/icons'}" />
      </template>
    </sidebar>
    <div class="main-content bg-main">
      <dashboard-navbar></dashboard-navbar>
      <div class="container-fluid">
        <div class="row">
          <div class="col-9">
            <router-view></router-view>
          </div>
          <div class="col-3">
            <right-bar></right-bar>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import { State, Action, Getter } from 'vuex-class'
import { Component } from 'vue-property-decorator'
import { DashboardState } from '../store/DashboardLayout/tupes'

const namespace: string = 'dashboard'

@Component({ name: 'dashboard-layout' })
export default class Dashboard extends Vue {
  @State('dashboard')
  public dashboard!: DashboardState;
  @Action('toggleSidebar', { namespace })
  public toggleSidebar: any

  mounted () {
    // получение данных после монтирования компонента
    this.toggleSidebar()
  }
}
</script>
