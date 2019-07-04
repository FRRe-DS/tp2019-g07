using FluentNHibernate.Mapping;
using webapif.Models.entidades;

namespace webapif.Models.mapeo
{
  public  class ExploracionGeneralMap:ClassMap<ExploracionGeneral>
    {
        public ExploracionGeneralMap()
        {
            Id(c => c.idExploracionGeneral);
            Map(c => c.idExpediente);
            Map(c => c.EdoConciencia);
            Map(c => c.marcha);
            Map(c => c.hidratacion);
            Map(c => c.coloracion);
            Map(c => c.valoracion);
            Map(c => c.observacion);

            //References(c => c.idEltoEvaluar).Column("idEltoEvaluar");

            Table("ExploracionGeneral");
        }

    }
}
