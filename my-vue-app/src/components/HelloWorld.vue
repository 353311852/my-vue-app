<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <h2>Essential Links</h2>
    <login v-on:listenLoginUserInfo="showChildLoginUser"
    v-on:listenLoginUserName="showChildLoginUserName"
    v-on:listenLoginUserPwd="showChildLoginUserPwd"
    />
    <ul>
      <li>

        <hello-parent-test/>
        <hello-test2/>
        <router-link to="about">go to about</router-link>
        <button-counter/>
        <agg v-bind:user="{
          name:'白泽',
          age:26
        }" />
      </li>
      <li>
        <a
          href="https://vuejs.org"
          target="_blank"
        >
          Core Docs
        </a>
      </li>
      <li>
        <a
          href="https://forum.vuejs.org"
          target="_blank"
        >
          Forum
        </a>
      </li>
      <li>
        <a
          href="https://chat.vuejs.org"
          target="_blank"
        >
          Community Chat
        </a>
      </li>
      <li>
        <a
          href="https://twitter.com/vuejs"
          target="_blank"
        >
          Twitter
        </a>
      </li>
      <br>
      <li>
        <a
          href="http://vuejs-templates.github.io/webpack/"
          target="_blank"
        >
          Docs for This Template
        </a>
      </li>
    </ul>
    <h2>Ecosystem</h2>
    <ul>
      <li>
        <a
          href="http://router.vuejs.org/"
          target="_blank"
        >
          vue-router
        </a>
      </li>
      <li>
        <a
          href="http://vuex.vuejs.org/"
          target="_blank"
        >
          vuex
        </a>
      </li>
      <li>
        <a
          href="http://vue-loader.vuejs.org/"
          target="_blank"
        >
          vue-loader
        </a>
      </li>
      <li>
        <a
          href="https://github.com/vuejs/awesome-vue"
          target="_blank"
        >
          awesome-vue
        </a>
      </li>
    </ul>
  </div>
</template>

<script>
import agg from './HelloWorld2'
import login from './login'
// import vue from 'vue'
var helloChildTestComponent = {
  template: '<p>this is {{msg}}</p>',
  props: ['msg']
}
var helloPatentTestComponent = {
  template: '<div><p>this is helloPatentTest</p><hello-child-test msg="你好啊 我的子元素" /></div>',
  components: {
    helloChildTest: helloChildTestComponent
  }
}

// vue.component('hello-test', helloTestComponent)
export default {
  name: 'HelloWorld',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
    }
  },
  components: {
    agg,
    helloParentTest: helloPatentTestComponent,
    login
  },
  methods: {
    showChildLoginUser (data) {
      alert(data)
    },
    showChildLoginUserPwd (data) {
      alert(data)
    },
    showChildLoginUserName (data) {
      alert(data)
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
