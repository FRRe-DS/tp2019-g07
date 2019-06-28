import { Component, OnInit } from '@angular/core';
import { Estudio } from 'src/app/Modelo/estudio';
import { EstudioService } from 'src/app/Servicio/estudio.service';
import { Router, ActivatedRoute } from '@angular/router';
import { CategoriaExamen } from 'src/app/Modelo/categoriaexamen';
@Component({
  selector: 'app-estudio',
  templateUrl: './estudio.component.html',
  styleUrls: ['./estudio.component.css']
})

export class EstudioComponent implements OnInit {

  estudios: Estudio[];
  miCategoriaExamen: CategoriaExamen[];

  constructor(private estudioServicio: EstudioService, private router: Router, private activateRoute: ActivatedRoute) { }

  




  ngOnInit() {
    const params = this.activateRoute.snapshot.params;
    if (params.id) {
      this.estudioServicio.getAllEstudioFromTramiteMedico(params.id)
      .subscribe(
        response => {
          console.log(response);
          this.estudios = response;
          
        }
      );
    }


  }

}
