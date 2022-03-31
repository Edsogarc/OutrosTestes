using Exe09.Entities;

namespace Exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("BMW", "X500", "MKOL-1452", "Branca", "0", false, 0, 0, 5000.0);
            Console.WriteLine(veiculo);
            veiculo.Abastecer(50);
            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Acelerar();
            veiculo.Acelerar();

            veiculo.Desligar();
            veiculo.Frear();
            veiculo.Desligar();
            veiculo.Frear();
            veiculo.Desligar();
            veiculo.Frear();
            veiculo.Desligar();
            veiculo.Pintar("Preto");
            Console.WriteLine(veiculo);
        }
    }
}