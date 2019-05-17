using System;
using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
 public   class PadecimientoActualMap:ClassMap<PadecimientoActual>
    {
        public PadecimientoActualMap()
        {
            Id(c => c.idPadecimiento);
            Map(c => c.idExpediente);
            Map(c => c.valoracion);
            Map(c => c.observacion);
            Table("PadecimientoActual");
        }
    }
}
