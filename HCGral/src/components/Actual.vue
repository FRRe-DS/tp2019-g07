<template>
    <b-container id="actual">
      <encabezado :titulo="titulopag"></encabezado>
      
      <hr>  
        <b-row>
        <!-- CARGA -->
        <b-col>
        <b-card bg-variant="light" 
                style="max-width: 20rem;"
                class="mb-2">

             <b-form @submit.prevent="onSubmit">
                <b-form-group
                  id="observacion"
                  label="Descripción:"
                  label-for="descripcion"
                >
                  <b-form-input
                    id="descripcion"
                    v-model="form.descripcion"
                    type="text"
                    ></b-form-input>
                </b-form-group>

                <b-form-group
                  id="valoracion"
                  label="Valoración"
                  label-for="valoracion"
                >
                  <b-form-input
                    id="observacion"
                    v-model="form.valoracion"
                    type="text"
                    ></b-form-input>
                </b-form-group>

                <b-form-group id="observacion" 
                              label="Observaciones:" 
                              label-for="observacion">
                  <b-form-textarea id="observacion"
                                v-model="form.observacion" 
                                type="text" 
                                required 
                                aria-placeholder="Ingrese sus Observaciones"
                  ></b-form-textarea>
                </b-form-group>
               
                <b-button  type="submit" variant="outline-primary">Guardar</b-button>
                             
            </b-form>
        </b-card>
        </b-col>
    </b-row>
    </b-container>
</template>

<script>
import Encabezado from '@/components/Encabezado';
import padecimientoactualService from '../api-services/padecimientoactual.service';

export default {
    name: 'Actual',
    components: {
        Encabezado
    },
    data: function (){
        return { 
            titulopag:'Padecimiento Actual',
            form:{
                descripcion:'',
                valoracion:'',
                observacion:''
            }                
        }
    },
    methods:{
        
    },
    computed:{
        
    }
}
</script>


