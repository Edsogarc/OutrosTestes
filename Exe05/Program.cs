// Contar letras da última palavra
class Program
{
    static void Main(string[] args)
    {
        string frase1 = "Na minha máquina funciona";
        string frase2 = "Eu posso pular o teste";
        string frase3 = "Isso não deve demorar";

        ContarLetras(frase1);
        ContarLetras(frase2);
        ContarLetras(frase3);

    }
    static void ContarLetras(string frase)
    { 
        string[] palavra = frase.Split(' ');
        int palavras = palavra.Length;
        int i = 0;
        while (i != palavras)
        {
            i++;
        }
        i--;
        Console.WriteLine(palavra[i].Length);
    }
}
