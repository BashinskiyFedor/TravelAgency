<template>
  <nav :class ="dashboard"
       id="navbar-vertical"
       class="navbar collapse navbar-expand-md navbar-vertical fixed-left navbar-dark bg-sidebar">
    <ul class="navbar-nav">
      <slot name="links"></slot>
    </ul>
  </nav>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'
import { State, Action, Getter } from 'vuex-class'
import { DashboardState } from '@/store/DashboardLayout/tupes'

const namespace: string = 'dashboard'
@Component
export default class Sidebar extends Vue {
  name!: 'sidebar'
  @State('dashboard')
  public dashboard!: DashboardState
  @Action('toggleSidebar', { namespace })
  public toggleSidebar: any

  mounted () {
    this.toggleSidebar()
  }
}
</script>
