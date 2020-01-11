<template>
  <base-nav class="navbar navbar-top navbar-expand-lg navbar-light bg-navbar"
            id="navbar-main"
            :show-toggle-button="false"
            expand>
    <a class="sidebarToggle pr-3" href="#" @click="toggleSidebar">
      <span class="icon icon-shape text-white bg-darken2 rounded-circle shadow">
        <icon :icon="['fas', 'bars']"></icon>
      </span>
    </a>

    <a class="navbar-brand text-white" href="#">Statistics</a>
    <button class="navbar-toggler"
            type="button"
            data-toggle="collapse"
            data-target="#navbarSupportContent"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse  ml-auto" id="navbarSupportedContent">
      <form class="navbar-search navbar-search-dark form-inline ml-auto">
        <div class="form-group mb-0">
          <base-input placeholder="Search"
                      class="input-group-alternative"
                      alternative="">
          </base-input>
        </div>
      </form>
    </div>
  </base-nav>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'
import { State, Getter, Action } from 'vuex-class'
import { DashboardState } from '@/store/DashboardLayout/tupes'
const namespace: string = 'dashboard'

@Component
export default class DashboardNavbar extends Vue {
  name!: 'dashboard-navbar'
  @State('dashboard')
  public dashboard!: DashboardState
  @Action('toggleSidebar', { namespace })
  public toggleSidebar: any
  mounted () {
    this.toggleSidebar()
  }
}
</script>
