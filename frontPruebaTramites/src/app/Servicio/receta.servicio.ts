
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tramite } from '../Modelo/tramite';
import { Estudio } from '../Modelo/estudio';
import { Receta } from '../Modelo/receta';



@Injectable({
    providedIn: 'root'
})

export class RecetaService {

    API_URI3 = 'http://localhost:8087/api/examen/informacionReceta';
     

    constructor(private httpService: HttpClient) { } // inyeccion de dependecia

    getAllReceta() {
        return this.httpService.get<Receta[]>(`${this.API_URI3}`);
    }

    getAllRecetaFromTramiteMedico(idReceta: number) {
        return this.httpService.get<Receta[]>(`${this.API_URI3}/medico/${idReceta}`);
    }
    
    getReceta(id: number) {
        return this.httpService.get<Receta>(`${this.API_URI3}/${id}`);
    }

    saveReceta(receta: Receta){
        return this.httpService.post(`${this.API_URI3}`, receta);
    }

    updateEstudio(updateReceta: Receta) {
        return this.httpService.put(`${this.API_URI3}`, updateReceta);
    }

    // no creo que sea necesario un DELETE, pero lo dejo por las dudas.
    deleteReceta(id: number){
        return this.httpService.delete(`${this.API_URI3}/${id}`);
    }

     

}