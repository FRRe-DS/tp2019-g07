import { Tramite } from './tramite';
import { CategoriaExamen } from './categoriaexamen';

export class Estudio {

    ideTramiteExamenDatoLinea?: number;
    tramite?: Tramite;
    resultadoExamen?: string;
    estadoEstudio?: string;
    fechaEstudio?: Date;
    categoriaExamen?: CategoriaExamen;
}
