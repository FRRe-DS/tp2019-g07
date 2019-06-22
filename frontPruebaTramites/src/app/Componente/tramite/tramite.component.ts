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


  constructor(private tramiteServicio: TramiteService) { }

  ngOnInit() {
     this.tramiteServicio.getAllTramites().subscribe(
       response => {
        console.log(response);
        this.tramites = response;
        }
     );
  }

  

}
