<template>
  <b-container id="actual">
      <encabezado :titulo="titulopag"></encabezado>
      
      <hr>  
       
        <!-- CARGA -->
        <b-col class="center">
        <b-card bg-variant="light" 
                style="max-width: 20rem;"
                class="mb-2">

             <b-form @submit.prevent="onSubmit" @reset.prevent="onReset">
               
              <b-form-group id="ta" 
                            label="TA (mmHg):" 
                            label-for="ta">
              <b-form-input id="ta" 
                            v-model="form.ta" 
                            type="text" 
                            required 
                            aria-placeholder="0"
                ></b-form-input>          
                  
              </b-form-group>                   
         
              <b-form-group id="fc" 
                            label="FC (Ipm):" 
                            label-for="ifc">
                <b-form-input id="fc" 
                              v-model="form.fc" 
                              type="text" 
                              required 
                              aria-placeholder="0"
                ></b-form-input>
                
              </b-form-group>
         

              

              <b-form-group id="temperatura" 
                            label="Temp. (ºC):" 
                            label-for="temperatura">
                <b-form-input id="temperatura" 
                              v-model="form.temperatura" 
                              type="text" 
                              required 
                              aria-placeholder="0"
                ></b-form-input>
                
              </b-form-group>

              <b-form-group id="peso" 
                            label="Peso Kg):" 
                            label-for="peso">
                <b-form-input id="peso" 
                              v-model="form.peso" 
                              type="text" 
                              required 
                              aria-placeholder="0"
                ></b-form-input>
               
              </b-form-group>

              <b-form-group id="talla" 
                            label="Talla (cm):" 
                            label-for="talla">
                <b-form-input id="talla" 
                              v-model="form.talla" 
                              type="text" 
                              required 
                              aria-placeholder="0"
                ></b-form-input>
                
              </b-form-group>
      
              <b-form-group id="resultado" 
                            label="Resultado:" 
                            label-for="resultado">
                <b-form-input id="resultado" 
                              v-model="form.resultado" 
                              type="text" 
                              required 
                              aria-placeholder="Resultado"
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
import signovitalService from '../api-services/signovital.service';

export default {
  name: 'SignosVitales',
  components:{
    Encabezado
  },
  data: function () {
        return {
          titulopag:'Signos Vitales',
          form:{
            ta:'', 
            fc:'', 
            temperatura:'',
            peso:'',
            talla:'',
            resultado:'',
            observacion:''
          },
          alertModalTitle: '',
        alertModalContent: '',
        isSuccessfully: false
      }
  },
  methods: {
      onSubmit: function() {
        signovitalService.create(this.form).then(() => {
         
      
           this.isSuccessfully = true,
           this.alertModalTitle = 'Todo Ok!',
           this.alertModalContent = 'Se mandaron los datos',
           this.$refs.alertModal.show(),
             this.form = {
                  ta: '',
                  fc: '',
                  temperatura: '',
                  peso:'',
                  talla: '',
                  resultado: '',
                  observacion: '',
            }
          }).catch((error) => {
            this.isSuccessfully = false
           this.alertModalTitle = 'Error',
           this.alertModalContent = 'No se pudo enviar :(',
           this.$refs.alertModal.show()
          })
        },
         onAlertModalOkClick() {
          if (this.isSuccessfully) {
            this.show = true
            this.darOff= true
          }
        }
      },
      onReset() {
        
        // Reset our form values
        this.form.ta = '',
        this.form.fc = '',
        this.form.fr = '',
        this.form.temperatura = '',
        this.form.peso = '',
        this.form.talla = '',
        this.form.resultado = '',
        this.form.observacion = ''
       
        
        
      }
  
}
</script>


