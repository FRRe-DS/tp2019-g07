
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tramite } from '../Modelo/tramite';
import { Estudio } from '../Modelo/estudio';



@Injectable({
    providedIn: 'root'
})

export class EstudioService {

    API_URI = 'http://192.168.1.12:8087/api/examen/estudioSolicitado';
    API_URI2 = 'http://192.168.1.12:8087/api/examen/solicitud';

    constructor(private httpService: HttpClient) { } // inyeccion de dependecia

    getAllEstudio() {
        return this.httpService.get<Estudio[]>(`${this.API_URI}`);
    }

    getAllEstudioFromTramiteMedico(idTramite: number) {
        return this.httpService.get<Estudio[]>(`${this.API_URI2}/${idTramite}/estudiosSolicitados`);
    }
    
    getEstudio(id: number) {
        return this.httpService.get<Estudio>(`${this.API_URI}/${id}`);
    }

    saveEstudio(estudio: Estudio){
        return this.httpService.post(`${this.API_URI}`, estudio);
    }

    updateEstudio(updateEstudio: Estudio) {
        return this.httpService.put(`${this.API_URI}`, updateEstudio);
    }

    // no creo que sea necesario un DELETE, pero lo dejo por las dudas.
    deleteEstudio(id: number){
        return this.httpService.delete(`${this.API_URI}/${id}`);
    }

    getDetalleTramite(id: number) {
        return this.httpService.get<Estudio[]>(`${this.API_URI}/solicitud/${id}/estudiosSolicitados`);
    }

}

