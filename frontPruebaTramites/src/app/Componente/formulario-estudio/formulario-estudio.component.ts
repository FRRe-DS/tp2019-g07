import { Component, OnInit } from '@angular/core';
import { Estudio } from 'src/app/Modelo/estudio';
import { CategoriaExamen } from 'src/app/Modelo/categoriaexamen';
import { Tramite } from 'src/app/Modelo/tramite';
import {EstudioService} from  'src/app/Servicio/estudio.service';
@Component({
  selector: 'app-formulario-estudio',
  templateUrl: './formulario-estudio.component.html',
  styleUrls: ['./formulario-estudio.component.css']
})
export class FormularioEstudioComponent implements OnInit {


  miCategoriaExamen: CategoriaExamen = {
    codDato: 20,
    descripcionDato: '',
  };


  miEstudio: Estudio = {
    ideTramiteExamenDatoLinea: 0,
    tramite: null,
    categoriaExamen: this.miCategoriaExamen,
    resultadoExamen: '',
    estadoEstudio: '',
    fechaEstudio: new Date(),
  };


constructor( private estudioService: EstudioService ) { }

ngOnInit() {
  }

  saveNewEstudio

}
