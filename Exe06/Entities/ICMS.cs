using Exe06.Services;
using System.Globalization;
namespace Exe06.Entities
{
    class ICMS : AbstractImposto
    {
        public double Valor { get; set; }

        public ICMS(double valor)
        {
            Valor = valor;
        }
        public override double CalculaImposto(double valor)
        {
            return valor * 0.3;
        }

        public override string ToString()
        {
            return CalculaImposto(Valor).ToString("F1", CultureInfo.InvariantCulture);
        }
    }
}