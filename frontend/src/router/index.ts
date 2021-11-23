import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'

Vue.use(VueRouter)

export default new VueRouter({
  routes: [
    {
      path: '/',
      name: 'JokesHome',
      component: () => import('../views/JokesHome.vue')
    },
    {
      path: '/add',
      name: 'JokeAdd',
      component: () => import('../views/JokeAdd.vue')
    },
    {
      path: '/edit/:id',
      name: 'JokeEdit',
      component: () => import('../views/JokeEdit.vue')
    },
  ],
  mode: 'history'
}) 