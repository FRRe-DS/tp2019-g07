import { Injectable }  from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tramite } from '../Modelo/tramite';
@Injectable({
    providedIn: 'root'
})
export class TramiteService {

    API_URI = 'http://localhost:8087/api/examen';

    constructor(private http: HttpClient) { }

    getAllTramites(){
        return this.http.get(`${this.API_URI}/solicitud`);
    }

    getTramite(id: number) {
        return this.http.get(`${this.API_URI}/solicitud/${id}`);
    }

    saveTramite(tramite: Tramite){
        return this.http.post(`${this.API_URI}/solicitud`, tramite);
    }

    updateTramite(updateTramite: Tramite): Observable<Tramite>{
        return this.http.put(`${this.API_URI}/solicitud`, updateTramite);
    }

    // no creo que sea necesario un DELETE, pero lo dejo por las dudas.
    deleteTramite(id: number): Observable<Tramite>{
        return this.http.delete(`${this.API_URI}/solicitud/${id}`);
    }


}