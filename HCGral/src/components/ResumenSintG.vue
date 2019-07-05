<template>
    <b-container id="resumen">
          <encabezado :titulo="titulopag"></encabezado>
          <b-container>
            <b-container>
                 <b-card no-body header="Exploración General">
                 <div class="table-responsive">
                      <table class="table table-striped">
                        <thead>
                          <tr>
                            <th>Id</th>
                            <th>idExpediente</th>
                            <th>Sintoma</th>
                            <th>Valoración</th>
                            <th>Observaciones</th>
                          </tr>
                        </thead>
                        <tbody>
                          <tr
                            v-for="sintgral in expgrales"
                            :key="sintgral.idExploracionGeneral"
                            
                            @update="updateExpG"
                            @delete="deleteExpG"
                            >                       
                             <td>{{ sintgral.idSintomaGeneral }}</td>
                             <td>{{ sintgral.idExpediente }}</td>
                             <td>{{ sintgral.sintoma }}</td>
                             <td>{{ sintgral.valoracion }}</td>
                             <td>{{ sintgral.observacion }}</td>
                             <td>
                               <b-button variant="warning"
                                         @click="onUpdateClick"
                                         >Modificar</b-button>
                             </td>
                             <td>
                               <b-button variant="danger"
                                         @click="onDeleteClick"
                                         >Borrar</b-button>
                             </td>
                            </tr>
                        </tbody>
                      </table>
                    </div>
                </b-card>
             </b-container>
          </b-container>  
    </b-container>    
</template>

<script>
import Encabezado from '@/components/Encabezado';
import sintomageneralService from '../api-services/sintomageneral.service';


export default {
    name: 'ResumenExpG',
    components:{
        Encabezado,
        
        
    },
    data: function(){
        return{
            titulopag: 'Resumen',
            sintgrales:[]
        }
    },     
    created: function() {
        sintomageneralService.getAll().then((response) => {
          this.sintgrales = response.data
        })
    },
    methods:{
        onUpdateClick() {
          this.$emit('update', this.expgral.id)
        },
        onDeleteClick() {
          this.$emit('delete', this.expgral.id)
        }
    }
} 
</script>
