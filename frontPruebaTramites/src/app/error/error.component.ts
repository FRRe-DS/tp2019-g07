import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-error',
  templateUrl: './error.component.html',
  styleUrls: ['./error.component.css']
})
export class ErrorComponent implements OnInit {

  mensajeError = 'Se produjo un error, por favor contacte a soporte tecnico al 46355454 - suport123@gmail.com';

  constructor() { }

  ngOnInit() {
  }

}
