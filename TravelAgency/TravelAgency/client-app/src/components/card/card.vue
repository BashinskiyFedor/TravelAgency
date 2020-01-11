<template>
  <div class="card"
       :class="[{[`bg-${gradient}`]:gradient}]">
    <div class="card-header" v-if="$slots.header">
      <slot name="header"></slot>
    </div>
    <div class="card-body">
      <slot name="footer"></slot>
    </div>
  </div>
</template>

<script lang="ts">
  import { Component, Prop, Vue } from 'vue-property-decorator'
  @Component({
    name: 'card'
  })
  export default class Card extends Vue {
    @Prop({
      type: String,
      default: 'darken2'
    })
    gradient!: string
  }
</script>
