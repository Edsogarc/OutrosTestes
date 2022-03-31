using Exe06.Services;
using System.Globalization;
namespace Exe06.Entities
{
    class IPI : AbstractImposto
    {
        public double Valor { get; set; }
        public IPI(double valor)
        {
            Valor = valor;
        }
        public override double CalculaImposto(double valor)
        {
            double result = 0.0;
            if (valor < 25000)
            {
                return result = valor * 0.05;
            }
            else
            {
                return result = valor * 0.1;
            }
        }
        public override string ToString()
        {
            return CalculaImposto(Valor).ToString("F1", CultureInfo.InvariantCulture);
        }
    }
}