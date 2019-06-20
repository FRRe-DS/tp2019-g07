import { Component, OnInit } from '@angular/core';


export class Tramite {

  constructor(
    public id: number,
    public id_personal_med: number,
    public fec_examen: Date,
    public id_internacion: number,
    public novedades: number
  ){

  }

}

@Component({
  selector: 'app-lista-tramite',
  templateUrl: './lista-tramite.component.html',
  styleUrls: ['./lista-tramite.component.css']
})
export class ListaTramiteComponent implements OnInit {

  tramite = [
    new Tramite (1,123, new Date(), 2133, 2),
    new Tramite (2,143, new Date(), 2133, 0),
    new Tramite (3,113, new Date(), 1233, 1),
    new Tramite (4,103, new Date(), 4133, 4),
  ];

  constructor() { }

  ngOnInit() {
  }

}
