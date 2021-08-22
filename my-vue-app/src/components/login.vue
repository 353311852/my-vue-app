<template>
    <div>
        用户名:<input type="text" v-model="user.username"/>
        密码:<input type="text" v-model="user.pwd"/>
        <button @click="login">登录</button>
    </div>
</template>
<script>
export default {
  name: 'login',
  data () {
    return {
      user: {},
      userJson: ''
    }
  },
  methods: {
    login () {
      this.userJson = JSON.stringify(this.user)
      this.$emit('listenLoginUserInfo', this.userJson)
      this.$emit('listenLoginUserName', this.user.username)
      this.$emit('listenLoginUserPwd', this.user.pwd)
    }
  }
}
</script>
