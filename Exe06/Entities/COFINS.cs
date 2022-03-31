using Exe06.Services;
using System.Globalization;
namespace Exe06.Entities
{
    class COFINS : AbstractImposto
    {
        public double Valor { get; set; }
        public COFINS(double valor)
        {
            Valor = valor;
        }
        public override double CalculaImposto(double valor)
        {
            double result = 0.0;
            if (valor > 17000)
            {
                return result = valor * 0.08;
            }
            else
            {
                return 0;
            }
            
        }
        public override string ToString()
        {
            return CalculaImposto(Valor).ToString("F1", CultureInfo.InvariantCulture);
        }
    }
}