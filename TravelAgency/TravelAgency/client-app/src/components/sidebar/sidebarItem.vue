<template>
  <li class="nav-item">
    <router-link :to="link.path"
                 class="nav-link"
                 :target="link.target"
                 :href="link.path"
    >
      <template>
        <icon :icon="link.icon"></icon>
        <span class="nav-link-text">{{ link.name }}</span>
      </template>
    </router-link>
  </li>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'

export interface ISideLink {
  name: string,
  path: string,
  icon: string | Array<string>
}

@Component
export default class SidebarItem extends Vue {
  name!: 'sidebarItem'
  @Prop() link!: ISideLink;
  @Prop() description!: string;

  children!: []
  collapsed!: true
}
</script>
