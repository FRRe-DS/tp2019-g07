import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.css']
})

export class WelcomeComponent implements OnInit {

   mensajeBienvenida = 'Bienvenido, esto funciona';
   nombreMostrar = '';



  // activarRuta--> que me estan pasando como paramentro welcome/nombreRuta
  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    console.log(this.mensajeBienvenida);
    // console.log(this.route.snapshot.params['nombre']);
    this.nombreMostrar = this.route.snapshot.params['nombre'];
  }

}
