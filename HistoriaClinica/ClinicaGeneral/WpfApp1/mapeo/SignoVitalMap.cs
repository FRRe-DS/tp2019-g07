using FluentNHibernate.Mapping;
using WpfApp1.entidades;

namespace WpfApp1.mapeo
{
 public   class SignoVitalMap:ClassMap<SignoVital>
    {
        public SignoVitalMap()
        {
            Id(c => c.idSignoVital);
            Map(c => c.idSignoEvaluar);
            Map(c => c.idExpediente);
            Map(c => c.resultado);
            Map(c => c.observacion);

            //References(c => c.idSignoEvaluar).Column("idSingoEvaluar");

            Table("SignoVital");
        }
    }
}
