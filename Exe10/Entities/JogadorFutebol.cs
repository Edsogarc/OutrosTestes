namespace Exe10.Entities
{
    class JogadorFutebol
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime DataNacimento { get; set; }
        public JogadorFutebol()
        {
            
        }
        public JogadorFutebol(string nome, string posicao, DateTime dataNacimento)
        {
            Nome = nome;
            Posicao = posicao;
            DataNacimento = dataNacimento;
        }
        public int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNacimento.Year;
            return idade;
        }
        public int CalcularAposentadoria()
        {
            if (Posicao == "Defesa")
            {
                if (CalcularIdade() >= 40)
                {
                    return 0;
                }
                else
                {
                    return 40 - CalcularIdade();
                }
            }
            else if (Posicao == "Meio-campo")
            {
                if (CalcularIdade() >= 38)
                {
                    return 0;
                }
                else
                {
                    return 38 - CalcularIdade();
                }
            }
            else
            {
                if (CalcularIdade() >= 35)
                {
                    return 0;
                }
                else
                {
                    return 35 - CalcularIdade();
                }
            }
        }
        public override string ToString()
        {
            return "Nome: " + Nome
            + ", Posição: " + Posicao
            + ", Data de nascimento: " + DataNacimento.ToString("dd/MM/yyyy")
            + ", Idade "+CalcularIdade()+" anos"
            + ", Tempo que falta para se aposentar "+ CalcularAposentadoria() +" anos";
        }

    }
}