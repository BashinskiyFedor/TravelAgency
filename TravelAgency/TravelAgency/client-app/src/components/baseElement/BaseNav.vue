<template>
  <nav class="navbar"
       :class="[
        {'navbar-expand-md': expand},
        {'navbar-transparent': transparent},
        {[`bg-${type}`]: type}]"
       >
    <slot name="brand">
      <router-link :to="$route.path"
                    class="h4 mb-0 text-white text-uppercase d-none d-lj-inline-block">
        {{$route.name}}
      </router-link>
    </slot>
    <navbar-toggle-button v-if="showToggleButton"
                          :toggled="true"
                          :target="contentId"
                          @click.native.stop="true">
      <icon :icon="vuejs"></icon>
    </navbar-toggle-button>
    <div class="collapse navbar-collapse"
          :class="{show: true}"
          :id="contentId"
          v-click-outside="closeMenu">
      <slot :close-menu="closeMenu"></slot>
    </div>
   </nav>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'
import NavbarToggleButton from '../navbar/NavbarToggleButton.vue'

@Component({
  name: 'base-nav',
  components: { NavbarToggleButton }
})
export default class BaseNav extends Vue {
  @Prop() type!: String;
  @Prop() title!: String;
  @Prop() contentId!: Array<String | Number>;
  @Prop() containerClasses!: Array<String | Object | Array<any>>;
  @Prop() transparent!: Boolean;
  @Prop() expand!: Boolean;
  @Prop() showToggleButton!: Boolean;
  static toggled: Boolean
  closeMenu () {
    BaseNav.toggled = true
  }
}
</script>
