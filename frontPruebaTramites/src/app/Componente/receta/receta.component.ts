import { Component, OnInit } from '@angular/core';
import { Receta } from 'src/app/Modelo/receta';
import { RecetaService } from 'src/app/Servicio/receta.servicio';

@Component({
  selector: 'app-receta',
  templateUrl: './receta.component.html',
  styleUrls: ['./receta.component.css']
})
export class RecetaComponent implements OnInit {

  recetas: Receta[];
  recetasMed: Receta[];
  idMed = 300; // ver como poder recibir este id a partir del login, el filtrado ya esta.


  constructor(private recetaServicio: RecetaService) { }

  ngOnInit() {
    this.getAllRecetaMedico(300);
  }

  getAllRecetaMedico(id: number) {
    this.recetaServicio.getAllRecetaFromTramiteMedico(id).subscribe(
    response => {
     console.log(response);
     this.recetas = response;
     }
  );
}


}
