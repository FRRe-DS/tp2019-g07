using System;
using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
  public  class ElementoEvaluacionSignoMap:ClassMap<ElementoEvaluacionSigno>
    {
        public ElementoEvaluacionSignoMap()
        {
            Id(c => c.idSignoEvaluar);
            Map(c => c.nombreSigno);

            Table("ElementoEvaluacionSigno");
        }
    }
}
