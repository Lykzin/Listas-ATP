using System;

public class Exercicio6 
{
    public static void Rodar() 
    {
        Console.WriteLine("\nDigite a quantidade de números (N):");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            int numero = int.Parse(Console.ReadLine());

            bool positivo = VerificarPositivo(numero);
            if (positivo)
            {
                Console.WriteLine($"{numero} é um número positivo.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número negativo.");
            }
        }
    }

    static bool VerificarPositivo(int numero)
    {
        return numero >= 0;
    }
}
