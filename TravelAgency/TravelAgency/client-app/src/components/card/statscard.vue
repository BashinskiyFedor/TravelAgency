<template>
  <card class="stats-card">
    <div class="row">
      <div class="col">
        <slot>
          <h5 class="text-uppercase card-title text-muted">{{title}}</h5>
          <span class="h2 text-white font-weight-bold mb-0"></span>
        </slot>
      </div>
      <div class="col-auto d-flex align-items-centr" v-if="icon">
        <div class="icon icon-shape text-white rounded-circle shadow"
             :class="[`bg-${type}`, iconClasses]">
          <icon :icon="icon"></icon>
        </div>
      </div>
    </div>
    <p class="mt-3 mb-0 text-sm"
       <slot name="footer">
       </slot>
    </p>
  </card>
</template>

<script lang="ts">
  import { Component, Prop, Vue } from 'vue-property-decorator'
  @Component({ name: 'stats-card' })
  export default class StatsCard extends Vue {
    @Prop({ default: 'dark' }) type!: String
    @Prop({ default: 'Title' }) title!: String
    @Prop({ default: 'Subtitle' }) subTitle!: String
    @Prop([String, Array]) icon!: String | Array<string>
    @Prop([String, Array]) iconClasses!: String | Array<string>
  }
</script>
