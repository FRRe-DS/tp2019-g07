using FluentNHibernate.Mapping;
using webapif.Models.entidades;

namespace webapif.Models.mapeo
{
  public  class SintomaGeneralMap:ClassMap<SintomaGeneral>
    {
        public SintomaGeneralMap()
        {
            Id(c => c.idSintomaGeneral);
          
            Map(c => c.idExpediente);
            Map(c => c.Sintoma);
            Map(c => c.valoracion);
            Map(c => c.observacion);

           Table("SintomaGeneral");
        }
    }
}
