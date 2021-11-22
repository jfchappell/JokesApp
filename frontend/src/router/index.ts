import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'JokesHome',
    component: () => import('../views/JokesHome.vue')
  },
  {
    path: '/add',
    name: 'JokesAdd',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/JokesAdd.vue')
  },
  {
    path: '/edit',
    name: 'JokesEdit',
    component: () => import('../views/JokesEdit.vue')
  },
  {
    path: '/delete',
    name: 'JokesDelete',
    component: () => import('../views/JokesDelete.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
