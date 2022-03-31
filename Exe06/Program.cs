using Exe06.Entities;
using Exe06.Services;
using System.Globalization;

namespace Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("ICMS: ");
            ICMS icms = new ICMS(valor);
            Console.WriteLine(icms);
            Console.Write("IPI: ");
            IPI ipi = new IPI(valor);
            Console.WriteLine(ipi);
            Console.Write("COFINS: ");
            COFINS cofins = new COFINS(valor);
            Console.WriteLine(cofins);
            double valorTotal = icms.CalculaImposto(valor)+ipi.CalculaImposto(valor)+cofins.CalculaImposto(valor)+valor;
            Console.WriteLine("Valor Final: "+valorTotal.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
