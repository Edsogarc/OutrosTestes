using Exe10.Entities;
namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Posição: ");
            string posicao = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            JogadorFutebol jogador = new JogadorFutebol(nome, posicao, dataNascimento);        
            Console.WriteLine(jogador);
        }
    }
}
