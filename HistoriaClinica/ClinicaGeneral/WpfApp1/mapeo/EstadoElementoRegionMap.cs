using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
 public   class EstadoElementoRegionMap:ClassMap<EstadoElementoRegion>
    {
        public EstadoElementoRegionMap()
        {
            Id(c => c.idestadoregional);
            Map(c => c.idregion);
            Map(c => c.nomestadoelto);

            //References(c => c.idRegion).Column("idRegion");

            Table("estadoelementoregion");
        }

    }
}
