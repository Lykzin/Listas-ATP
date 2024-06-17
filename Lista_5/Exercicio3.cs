using System;
using System.Collections.Generic;

class Exercicio3
{
    public static void Rodar()
    {
        int[] X = new int[10];
        PreencherVetor(X);
        int[] negativos = CopiarValoresNegativos(X);
        ExibirVetor("Vetor original", X);
        ExibirVetor("Vetor com valores negativos", negativos);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite os 10 elementos do vetor:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int[] CopiarValoresNegativos(int[] vetor)
    {
        List<int> negativos = new List<int>();
        foreach (int valor in vetor)
        {
            if (valor < 0)
            {
                negativos.Add(valor);
            }
        }
        return negativos.ToArray();
    }

    static void ExibirVetor(string descricao, int[] vetor)
    {
        Console.WriteLine($"{descricao}:");
        foreach (int valor in vetor)
        {
            Console.Write($"{valor} ");
        }
        Console.WriteLine();
    }
}
