import Vue from 'vue';
import Router from 'vue-router';
import SignosVitales from '@/components/SignosVitales'
import Actual from '@/components/Actual';
import SintomaGral from '@/components/SintomaGral';
import ExpGeneral from '@/components/ExpGeneral';
import ExpRegional from '@/components/ExpRegional';
import ResumenExpG from '@/components/ResumenExpG';
import ResumenSintG from '@/components/ResumenSintG';
import NotFound from '@/error-pages/NotFound';


Vue.use(Router);

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'SignosVitales',
      component: SignosVitales,
    },
    {
      path: '/actual',
      name: 'Actual',
      component: Actual,
    },
    {
      path: '/sgral',
      name: 'SintomaGral',
      component: SintomaGral,
    },
    {
      path: '/sgral/resumen',
      name: 'ResumenSintG',
      component: ResumenSintG,
    },
    {
      path: '/expregional',
      name: 'ExpRegional',
      component: ExpRegional,
    },
    {
      path: '/expgeneral',
      name: 'ExpGeneral',
      component: ExpGeneral,
    },
    {
      path: '/expgeneral/resumen',
      name: 'ResumenExpG',
      component: ResumenExpG,
    },
    {
      path: '*',
      name: 'NotFound',
      component: NotFound
    }
  ],
});
