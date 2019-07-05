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
                            <th>Edo. Conciencia</th>
                            <th>Marcha</th>
                            <th>Hidratación</th>
                            <th>Coloración</th>
                            <th>Valoración</th>
                            <th>Observaciones</th>
                          </tr>
                        </thead>
                        <tbody>
                          <tr
                            v-for="expgral in expgrales"
                            :key="expgral.idExploracionGeneral"
                            
                            @update="updateExpG"
                            @delete="deleteExpG"
                            >                       
                             <td>{{ expgral.idExploracionGeneral }}</td>
                             <td>{{ expgral.idExpediente }}</td>
                             <td>{{ expgral.EdoConciencia }}</td>
                             <td>{{ expgral.marcha }}</td>
                             <td>{{ expgral.hidratacion }}</td>
                             <td>{{ expgral.coloracion }}</td>
                             <td>{{ expgral.valoracion }}</td>
                             <td>{{ expgral.observacion }}</td>
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
import exploraciongeneralService from '../api-services/exploraciongeneral.service';


export default {
    name: 'ResumenExpG',
    components:{
        Encabezado,
        
        
    },
    
    data: function(){
        return{
            titulopag: 'Resumen',
            expgrales:[]
        }
    },     
    created: function() {
        exploraciongeneralService.getAll().then((response) => {
          this.expgrales = response.data
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
