using System;

// Inverter um inteiro
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para ser invertido: ");
        Int64 numero = Int64.Parse(Console.ReadLine());

        Inverter(numero);


        static void Inverter(Int64 n)
        {
            string valor = Convert.ToString(n);
            string[] valores = new string[valor.Length];
            for (int i = 0; i < valor.Length; i++)
            {
                valores[i] = valor[i] + "";
                if (i == valor.Length - 1)
                {
                    Console.Write(valores[i] + " --> ");
                    for (int j = 1; j <= valores.Length; j++)
                    {
                        Console.Write(valores[valores.Length - j]);
                    }
                }
                else
                {
                    Console.Write(valores[i]);
                }
            }
            Console.WriteLine();
        }
    }
}