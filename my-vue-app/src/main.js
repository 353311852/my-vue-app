// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'

Vue.config.productionTip = false
// 定义一个名为 button-counter 的新组件
Vue.component('button-counter', {
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
  template: '<button v-on:click=sum>You clicked me {{ count }} times.</button>'
})
Vue.component('hello-test2', {
  template: '<div><p>this is helloTest2</p></div>'
})
/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
