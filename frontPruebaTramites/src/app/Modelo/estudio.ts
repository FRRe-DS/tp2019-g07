import { Tramite } from './tramite';
import { CategoriaExamen } from './categoriaexamen';

export class Estudio {

// tslint:disable-next-line: variable-name
    ide_TramiteExamenDatoLinea?: number;
    tramite?: Tramite;
    resultadoExamen?: string;
    estadoEstudio?: string;
    fechaEstudio?: Date;
    categoriaExamen?: CategoriaExamen;


}