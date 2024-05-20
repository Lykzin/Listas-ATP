using System;

public class Exercicio8 
{
    public static void Rodar() 
    {
        Console.WriteLine("\nDigite o valor de N:");
        int n = int.Parse(Console.ReadLine());

        double resultado = CalcularS(n);

        Console.WriteLine($"O valor de S é: {resultado}");
    }

    static double CalcularS(int n)
    {
        double soma = 0;

        for (int i = 1; i <= n; i++)
        {
            soma += (Math.Pow(i, 2) + 1) / (double)(i + 3);
        }

        return soma;
    }
}