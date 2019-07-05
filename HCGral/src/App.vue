<template>
  <b-container  id="app" >
    <div class="page-header bg-dark text-white">  
      <h1 class="text-center"> <u>Historia Clínica</u> </h1>
      <h4 class="text-center"> Área: Clínica General </h4>
      <navbar/>
    </div>
     <!-- 
      Para mostrar el nro expediente 
      <b-container id="showexpediente">
        <span v-text="idExpediente"/>
      </b-container>
    -->
      <div class="container shadow-lg p-3 mb-5 bg-white rounded">
        <router-view/>
      </div>    
  </b-container>
</template>

<script>
import Navbar from '@/components/Navbar';

export default {
  name: 'App',
  components:{
    Navbar,
  }

};
</script>

<style>

</style>
