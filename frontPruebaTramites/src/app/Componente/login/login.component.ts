import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
 

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

   usuario = 'gonza';
   contrasena = '';
   mensajeError = 'Credenciales Erroneas';
   sesionCheck = false;

 // agrego la router y me permite usar inyeccion de dependecia  -->trae Router
  constructor(private router: Router) { }

  ngOnInit() {
  }

  manejarInicioSesion() {
    // redireccionar al componente de welcome
     if (this.usuario === 'gonza' && this.contrasena === 'dummy') {
        this.router.navigate(['welcome', this.usuario]);
        this.sesionCheck = false;
     } else {
       this.sesionCheck = true;
     }
  }


}
