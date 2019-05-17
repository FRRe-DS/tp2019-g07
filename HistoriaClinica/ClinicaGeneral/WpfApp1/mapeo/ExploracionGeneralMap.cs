using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
  public  class ExploracionGeneralMap:ClassMap<ExploracionGeneral>
    {
        public ExploracionGeneralMap()
        {
            Id(c => c.idExploracionGeneral);
            Map(c => c.idExpediente);
            Map(c => c.idEltoEvaluar);
            Map(c => c.valoracion);
            Map(c => c.observacion);

            //References(c => c.idEltoEvaluar).Column("idEltoEvaluar");

            Table("ExploracionGeneral");
        }

    }
}
