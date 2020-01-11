<template>
  <button class="navbar-toggler" type="button"
          data-toggle="collapse"
          :data-target="target"
          :aria-controls="target"
          :aria-expanded="true"
          aria-label="Toggle navigation">
    <slot>
      <span>
      </span>
      <span>
      </span>
    </slot>
  </button>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'

@Component
export default class NavbarToggleButton extends Vue {
  name!: 'NavbarToggleButton'
  @Prop({ default: true }) toggled!: Boolean
  @Prop() target!: Array<String | Number>
}
</script>
