<template>
   <b-container id="expgral ">
      <encabezado :titulo="titulopag"></encabezado>
      <hr>  
         
        <!-- CARGA -->
        <b-col class="center">
        <b-card bg-variant="light" 
                style="max-width: 20rem;"
                class="mb-2">

             <b-form @submit.prevent="onSubmit" @reset.prevent="onReset">
               
                
              
                <b-form-group
                  id="Region"
                  label="Region:"
                  label-for="region"
                >
                  <b-form-input
                    id="region"
                    v-model="form.region"
                    type="text"
                    ></b-form-input>
                </b-form-group>

                


                 <b-form-group
                  id="elemento"
                  label="Elemento:"
                  label-for="elemento"
                >
                  <b-form-input
                    id="elemento"
                    v-model="form.elemento"
                    type="text"
                    ></b-form-input>
                </b-form-group>
                
                <b-form-group label="Estado">
                   <b-form-radio v-model="form.estado" 
                                name="estado" 
                                :value="true">Bueno</b-form-radio>
                   <b-form-radio v-model="form.estado" 
                                name="estado" 
                                :value="false">Malo</b-form-radio>
                 </b-form-group>

                  <b-form-group
                     id="valoracion"
                     label="Valoracion:"
                     label-for="valoracion"
                   >
                     <b-form-input
                       id="valoracion"
                       v-model="form.valoracion"
                       type="text"
                       ></b-form-input>
                   </b-form-group>

                   <b-form-group id="observacion"
                                 label="Observaciones:" 
                                 label-for="observacion">
                     <b-form-textarea  id="observacion"
                                   v-model="form.observacion" 
                                   type="text"  
                     ></b-form-textarea>
                   </b-form-group>

                <b-button  type="submit" variant="outline-primary">Guardar</b-button>
                 <b-button  type="reset" variant="danger">Cancelar</b-button>            
            </b-form>
        </b-card>
        </b-col>
       
    
    
        <b-modal
          ref="alertModal"
          :title="alertModalTitle"
          :ok-only="true"
          @ok="onAlertModalOkClick">
          <p class="my-4">{{ alertModalContent }}</p>
        </b-modal>
    
    </b-container>
</template>

<script>
import Encabezado from '@/components/Encabezado';
import exploracionregionalService from '../api-services/exploracionregional.service';

export default {
    name: 'ExpRegional',
    components:{
        Encabezado
    },
    data: function(){
      return {
        titulopag: 'Exploracion Regional',
        form:{
          Region:'',
          elemento:'',
          estado: true,
          valoracion:'',
          observacion:''
          
        },
         alertModalTitle: '',
        alertModalContent: '',
        isSuccessfully: false
      }
    },
     methods:{

        //POST
        onSubmit: function() {
             
          //this.show=true (ver, tine que ir en computed)
          exploraciongeneralService.create(this.form).then(() => {
            this.isSuccessfully = true,
            this.alertModalTitle = 'Todo Ok!',
            this.alertModalContent = 'Se mandaron los datos',
            this.$refs.alertModal.show(),
        
            this.form={
              Region:'',
              elemento:'',
              estado: true,
              valoracion:'',
              observacion:''
            }
          }).catch((error) => {
            this.isSuccessfully = false,
            this.alertModalTitle = 'Error',
            this.alertModalContent = 'No se pudo enviar :(',
            this.$refs.alertModal.show()
          })
        },
        onReset(){
          this.form={
              Region:'',
              elemento:'',
              estado: true,
              valoracion:'',
              observacion:''
            }
        },
        // onAlertModalOkClick() {
        //  if (this.isSuccessfully) {
        //    this.$router.push({ name: 'ResumenExpR' })
        //  }
      //  }
      }
      
    
}
</script>
