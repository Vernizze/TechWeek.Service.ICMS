using TechWeek.Service.ICMS.DTOs;

namespace TechWeek.Service.ICMS.Domain
{
    public class Calcular
    {
        public CalculoICMSRetorno Run(CalculoICMSParametro param)
        {
            var valor = 0M;
            var baseCalculo = 0M;

            baseCalculo = (param.ValorItem - (param.ValorItem * (param.ReducaoBaseCalculo / 100)));

            valor = baseCalculo * (param.Aliquota / 100);

            return new CalculoICMSRetorno
            {
                Valor = valor,
                BaseCalculo = baseCalculo
            };
        }
    }
}
