using System;
public static class Exercicio3
{
    public static void Rodar()
    {
        Console.WriteLine("\nDigite o número de conjuntos de valores (N):");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o conjunto {i + 1} de 3 valores inteiros:");

            Console.Write("Valor 1: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Valor 3: ");
            int valor3 = int.Parse(Console.ReadLine());

            ExibirValoresEmOrdemCrescente(valor1, valor2, valor3);
        }
    }

    static void ExibirValoresEmOrdemCrescente(int a, int b, int c)
    {
        int menor, meio, maior;

        if (a <= b && a <= c)
        {
            menor = a;
            if (b <= c)
            {
                meio = b;
                maior = c;
            }
            else
            {
                meio = c;
                maior = b;
            }
        }
        else if (b <= a && b <= c)
        {
            menor = b;
            if (a <= c)
            {
                meio = a;
                maior = c;
            }
            else
            {
                meio = c;
                maior = a;
            }
        }
        else
        {
            menor = c;
            if (a <= b)
            {
                meio = a;
                maior = b;
            }
            else
            {
                meio = b;
                maior = a;
            }
        }

        Console.WriteLine($"Valores em ordem crescente: {menor}, {meio}, {maior}");
    }
}
