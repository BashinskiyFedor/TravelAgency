import DashboardLayout from '@/layouts/DashboardLayout.vue'

export const routes = [
  {
    path: '/dashboard',
    redirect: '/dashboard/statistics/',
    component: DashboardLayout,
    children: [{
      path: 'statistics',
      name: 'statistics',
      component: () => import(/* webpackChunkName: "demo" */ '../views/Statistics.vue')
    }]
  },
  {
    path: '/dashboard',
    redirect: '/dashboard/articles/',
    component: DashboardLayout,
    children: [{
      path: 'articles',
      name: 'articles',
      component: () => import(/* webpackChunkName: "demo" */ '../views/Articles.vue')
    }]
  }
]
