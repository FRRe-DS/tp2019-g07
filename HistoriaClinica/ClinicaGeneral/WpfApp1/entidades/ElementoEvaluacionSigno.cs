using System;


namespace WpfApp1.entidades
{

    /// <summary>
    /// Clase que contiene los distintos tipos de signo vital que presenta el cuerpo
    /// </summary>
  public  class ElementoEvaluacionSigno
    {
    
        public virtual int idSignoEvaluar { get; set; } // clave primaria
        public virtual string nombreSigno { get; set; } //  descripcion del nombre del signo vital

       
    }
}
