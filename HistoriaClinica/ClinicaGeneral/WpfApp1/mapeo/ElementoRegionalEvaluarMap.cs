using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
 public   class ElementoRegionalEvaluarMap:ClassMap<ElementoRegionalEvaluar>
    {
        public ElementoRegionalEvaluarMap()
        {
            Id(c => c.idElementoRegional);
            Map(c => c.idEstadoElto);
            Map(c => c.nombreEltoExplorado);

            //References(c => c.idEstadoElto).Column("idEstadoElto");

            Table("ElementoRegionalEvaluar");
        }
    }
}
