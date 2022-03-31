using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int[] valores = {8, 12, 25, 85, 63, 2, 10, 9, 6, 41, 32};
        if (valores.Length == 0)
        {
            Console.WriteLine("Array vazio");
        }
        else
        {
            Console.WriteLine(SomaValores(valores));
            Console.WriteLine(MediaValores(valores));
            Console.WriteLine(MaiorValor(valores));
            Console.WriteLine(MenorValor(valores));
            Console.WriteLine(Mediana(valores));
            Console.WriteLine(valores.Length);
        }
    }
    static int SomaValores(int[] valores)
    {
        int soma = 0;

        foreach (int numero in valores)
        {
            soma = soma + numero;
        }
        return soma;
    }
    static int MediaValores(int[] valores)
    {
        int contador = 0;
        int soma = 0;
        int media;
        foreach (int valor in valores)
        {
            soma = soma + valor;
            contador++;
        }
        media = soma / contador;
        return media;
    }
    static int Mediana(int[] valores)
    {
        int[] novoArray = valores.OrderBy(x => x).ToArray();
        int soma = 0;
        int mediana = 0;
        if (novoArray.Length % 2 == 0)
        {
            soma = novoArray[novoArray.Length / 2] + novoArray[(novoArray.Length / 2) + 1];
            mediana = soma / 2;
        }
        else
        {
            mediana = novoArray[novoArray.Length / 2 - 1];
        }
        return mediana;
    }
    static int MaiorValor(int[] valores)
    {
        int maior = 0;
        int temp;
        int contador = 0;
        for (int i = 1; i < valores.Length; i++)
        {
            if (valores[contador] > valores[i])
            {
                maior = valores[contador];
            }
            else
            {
                temp = valores[contador];
                valores[contador] = valores[i];
                valores[i] = valores[contador];

            }
        }
        return maior;
    }
    static int MenorValor(int[] valores)
    {
        int menor = 0;
        int contador = 0;
        int temp;
        for (int i = 1; i < valores.Length; i++)
        {
            if (valores[contador] < valores[i])
            {
                menor = valores[contador];
            }
            else
            {
                temp = valores[i];
                valores[i] = valores[contador];
                valores[contador] = temp;
            }
        }
        return menor;
    }
}
