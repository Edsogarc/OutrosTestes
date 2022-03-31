namespace Exe07.Entities
{
    class Caixa : Produtos
    {
        public int Quantidade { get; set; }

        public Caixa()
        {

        }
        public Caixa(int quantidade)
        {
            Quantidade = quantidade;
        }
        public Caixa(string nome, double valor, int tipo)
        : base(nome, valor, tipo)
        {

        }

        public double calculaValorFinal(Produtos produtos, int quantidade)
        {
            double soma = 0.0;
            double desconto = 0.0;
            if (produtos.Tipo == 1 && Quantidade < 5)
            {
                soma = produtos.Valor * quantidade;
                desconto = 0.1 * soma;
                return soma - desconto;
            }
            else if (produtos.Tipo == 2)
            {
                soma = produtos.Valor * quantidade;
                desconto = 0.2 * soma;
                return soma - desconto;
            }
            else
            {
                soma = produtos.Valor * quantidade;
                desconto = 0.1 * soma;
                return soma - desconto;
            }
        }
    }
}