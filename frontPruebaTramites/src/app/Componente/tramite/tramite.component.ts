import { Component, OnInit} from '@angular/core';

import {Tramite} from 'src/app/Modelo/tramite'; // importo el modelo
import { TramiteService} from 'src/app/Servicio/tramite.service';  // importo el servicio de tramite disponibles
import {Observable} from 'rxjs'
@Component({
  selector: 'app-tramite',
  templateUrl: './tramite.component.html',
  styleUrls: ['./tramite.component.css']
})

export class TramiteComponent implements OnInit {

  tramites: Tramite[];
  tramitesMed: Tramite[];
  var = 300;  // ver como poder recibir este id a partir del login, el filtrado ya esta.

  constructor(private tramiteServicio: TramiteService) { }

  ngOnInit() {
    this.getAllTramitesMedico(300);
  }

  getAllTramitesMedico(id: number) {
      this.tramiteServicio.getAllTramitesMedico(id).subscribe(
      response => {
       console.log(response);
       this.tramites = response;
       }
    );
  }

  getAllTramites() {
       this.tramiteServicio.getAllTramites().subscribe(
       response => {
        console.log(response);
        this.tramites = response;
        }
     );
  }


  

}
