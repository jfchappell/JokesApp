<template>
  <div id="app">
    <Navbar></Navbar>
    <div class="main-window">
      <router-view/>
    </div>
  </div>
</template>

<script lang="ts">
import Navbar from '@/components/Navbar.vue'

export default {
  components: {
    Navbar,
  }
}
</script>


<style lang="less">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

.main-window{
  margin-top: 0px;
}
</style>
