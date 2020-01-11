<template>
  <div class="home">
    <h1>Fufa</h1>
    <HelloWorld msg="Welcome to Your Vue.js App"/>
  </div>
</template>

<script lang="ts">
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'statistics',
  components: {
    HelloWorld
  }
}
</script>
