using System;

// Letra que não se repete

class Program
{
    static void Main(string[] args)
    {
        string a = "aaabccccdeeef";
        string b = "strings";
        string c = "microsoft visual studio 2022";
        string d = "abcedoftz";

        int index = PrimeiroNaoRepete(d);

        Console.WriteLine(index == -1 ? "Poder ser "
                                            + "Todoas os caracteres repetidos ou "
                                            + "string Vazio"
                                      : "Primeiro caracter que não se repeti"
                                            + " é " + d[index]);
    }
    static int quantidade = 256;
    static char[] count = new char[quantidade];
    static void ContagemCaracteres(string str)
    {
        for (int i = 0; i < str.Length; i++)
            count[str[i]]++;
    }
    static int PrimeiroNaoRepete(string str)
    {
        ContagemCaracteres(str);
        int index = -1, i;

        for (i = 0; i < str.Length; i++)
        {
            if (count[str[i]] == 1)
            {
                index = i;
                break;
            }
        }
        return index;
    }
}
