import { Component, OnInit } from '@angular/core';
import { Estudio } from 'src/app/Modelo/estudio';
import { CategoriaExamen } from 'src/app/Modelo/categoriaexamen';
import { Tramite } from 'src/app/Modelo/tramite';
import { EstudioService } from 'src/app/Servicio/estudio.service';
import { Router, ActivatedRoute } from '@angular/router';
import { TramiteService } from 'src/app/Servicio/tramite.service';
@Component({
  selector: 'app-formulario-estudio',
  templateUrl: './formulario-estudio.component.html',
  styleUrls: ['./formulario-estudio.component.css']
})
export class FormularioEstudioComponent implements OnInit {


  miCategoriaExamen: CategoriaExamen = {
    cod_sato: 62,
    descripcionDato: '',
  };


  unTramite: Tramite;


  miEstudio: Estudio = {
    tramite: this.unTramite,
    categoriaExamen: this.miCategoriaExamen,
    resultadoExamen: '',
    estadoEstudio: '',
    fechaEstudio: new Date(),
  };


  constructor(
    // tslint:disable-next-line: max-line-length
    private estudioServicio: EstudioService, private servicioTramite: TramiteService, private router: Router, private activateRoute: ActivatedRoute) { }
  ngOnInit() {
  }

  saveNewEstudio() {

    const params = this.activateRoute.snapshot.params;
    if (params.id) {
      //this.miEstudio.tramite = params.id;
      // this.unTramite.ideSolicitudExamen = params.id;
      this.miEstudio.tramite = this.unTramite;
      this.miEstudio.categoriaExamen.cod_dato = 62;
      console.log(this.miEstudio);
      this.servicioTramite.saveUnEstudioDeTramite(params.ideSolicitudExamen, this.miEstudio)
        .subscribe(
          res => {
            console.log(res);
            // this.router.navigate(['/mistramites']);
          }
        );
    }
  }





  getTramitesMedico(id: number) {
    this.servicioTramite.getTramite(id).subscribe(
      response => {
        console.log(response);
        this.unTramite = response;
        return this.unTramite;
      }
    );
  }

}
