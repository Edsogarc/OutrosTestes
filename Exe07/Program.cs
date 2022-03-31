using Exe07.Entities;

namespace Exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto1 = new Produtos("Banana", 0.99, 2);
            Produtos produto2 = new Produtos("Energético", 5.49, 3);
            Produtos produto3 = new Produtos("Arroz", 20.00, 1);
            Produtos produto4 = new Produtos("Chocolate", 4.50, 1);
            Produtos produto5 = new Produtos("Leite", 3.73, 3);
            Produtos produto6 = new Produtos("Abacaxi", 2.40, 2);

            Caixa caixa = new Caixa();
            Console.WriteLine(produto1.Nome+" R$"+caixa.calculaValorFinal(produto1, 3).ToString("F2"));
            Console.WriteLine(produto2.Nome+" R$"+caixa.calculaValorFinal(produto2, 7).ToString("F2"));
            Console.WriteLine(produto3.Nome+" R$"+caixa.calculaValorFinal(produto3, 1).ToString("F2"));
            Console.WriteLine(produto4.Nome+" R$"+caixa.calculaValorFinal(produto4, 12).ToString("F2"));
            Console.WriteLine(produto5.Nome+" R$"+caixa.calculaValorFinal(produto5, 5).ToString("F2"));
            Console.WriteLine(produto6.Nome+" R$"+caixa.calculaValorFinal(produto6, 1).ToString("F2"));

        }
    }
}
