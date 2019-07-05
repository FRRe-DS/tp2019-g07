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
                  id="sintoma"
                  label="Sintoma:"
                  label-for="marcha"
                >
                  <b-form-input
                    id="sintoma"
                    v-model="form.sintoma"
                    type="text"
                    ></b-form-input>
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
import sintomageneralService from '../api-services/sintomageneral.service';

export default {
    name:'SintomaGeneral',
    components: {
      Encabezado,
      
    },
    data: function(){
      return {
        titulopag: 'Sintoma General',
        form:{         
          sintoma:'',
          valoracion:'',
          observacion:''
        },
       
       // show: false,
        alertModalTitle: '',
        alertModalContent: '',
        isSuccessfully: false
      }
    },
     methods:{

        //POST
        onSubmit: function() {
             
          //this.show=true (ver, tine que ir en computed)
          sintomageneralService.create(this.form).then(() => {
            this.isSuccessfully = true,
            this.alertModalTitle = 'Todo Ok!',
            this.alertModalContent = 'Se mandaron los datos',
            this.$refs.alertModal.show(),
        
            this.form={
             
              sintoma:'',
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
             
              sintoma:'',
              valoracion:'',
              observacion:''
            }
        },
         onAlertModalOkClick() {
          if (this.isSuccessfully) {
            this.$router.push({ name: 'ResumenSintG' })
          }
        }
    },   computed:{
       
    },
    
   
}
</script>

<style>
.form-wrapper {
  margin-top: 20px;
  min-height: 20px;
  padding: 19px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border: 1px solid #e3e3e3;
  border-radius: 4px;
  box-shadow: inset 0 1px 1px rgba(0,0,0,.05);
}
</style>
