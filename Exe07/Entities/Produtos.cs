namespace Exe07.Entities
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Tipo { get; set; }

        public Produtos()
        {

        }
        public Produtos(string nome, double valor, int tipo)
        {
            Nome = nome;
            Valor = valor;
            Tipo = tipo;
        }

    }
}