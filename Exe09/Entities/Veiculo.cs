using System.Globalization;
namespace Exe09.Entities
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo()
        {

        }
        public Veiculo(string marca, string modelo, string placa, string cor, string km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            IsLigado = isLigado;
            LitrosCombustivel = litrosCombustivel;
            Velocidade = velocidade;
            Preco = preco;
        }
        public void Acelerar()
        {
            if (LitrosCombustivel == 0)
            {
                Console.WriteLine("Carro sem combustível");
            }
            else
            {
                Velocidade += 20;
                LitrosCombustivel -= 2;
            }
        }
        public void Abastecer(int litrosQuantidade)
        {
            if (litrosQuantidade <= 60)
            {
                LitrosCombustivel += litrosQuantidade;
            }
            else
            {
                Console.WriteLine("Capacidade do tanque 60 litros");
            }
        }
        public void Frear()
        {
            if (IsLigado == false || Velocidade >= 20)
            {
                Velocidade -= 20;
            }
        }
        public void Pintar(string cor)
        {
            Cor = cor;
        }
        public void Ligar()
        {
            if (Velocidade <= 0)
            {
                IsLigado = true;
                Console.WriteLine("Carro ligou!");
            }
            else
            {
                Console.WriteLine("Carro já está ligado!");
            }
        }
        public void Desligar()
        {
            if (Velocidade > 0)
            {
                Console.WriteLine("Carro em movimento, não é possível desligar");
            }
            else
            {
                IsLigado = false;
                Console.WriteLine("Carro desligou!");
            }
        }
        public override string ToString()
        {
            return "Marca: "+ Marca
            + ", Modelo: "+ Modelo
            + ", Placa: "+ Placa
            + ", Cor: " + Cor
            + ", KM: "+ Km
            + ", Combustível: " + LitrosCombustivel
            + ", Velocidade: " + Velocidade
            + ", Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}