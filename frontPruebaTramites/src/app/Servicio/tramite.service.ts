
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tramite } from '../Modelo/tramite';
import { Estudio } from '../Modelo/estudio';



@Injectable({
    providedIn: 'root'
})
export class TramiteService {

    API_URI = 'http://localhost:8087/api/examen';

    constructor(private httpService: HttpClient) { } // inyeccion de dependecia

    getAllTramites() {
        return this.httpService.get<Tramite[]>(`${this.API_URI}/solicitud`);
    }

    getTramite(id: number) {
        return this.httpService.get(`${this.API_URI}/solicitud/${id}`);
    }

    saveTramite(tramite: Tramite){
        return this.httpService.post(`${this.API_URI}/solicitud`, tramite);
    }

    updateTramite(updateTramite: Tramite) {
        return this.httpService.put(`${this.API_URI}/solicitud`, updateTramite);
    }

    // no creo que sea necesario un DELETE, pero lo dejo por las dudas.
    deleteTramite(id: number){
        return this.httpService.delete(`${this.API_URI}/solicitud/${id}`);
    }

    getDetalleTramite(id: number) {
        return this.httpService.get<Estudio[]>(`${this.API_URI}/solicitud/${id}/estudiosSolicitados`);
    }

}
