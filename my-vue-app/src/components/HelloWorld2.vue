<template>
<div>
  <button v-on:click=sum>You button child clicked me {{ count }} times.</button>
  <h2>{{user.name}}</h2>
  <h1>{{user.age}}</h1>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld2',
  data: function () {
    return {
      count: 0
    }
  },
  methods: {
    sum: function () {
      this.count++
    }
  },
  props: ['user']

  // components: {
  //   'btncount': buttonCounterChild
  // }
}
</script>

<style scoped>
button{
 background: blue;
 color: white;
 line-height: 20px;
}
</style>
