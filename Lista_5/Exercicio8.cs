using System;

class Exercicio8
{
    public static void Rodar()
    {

        int[,] matriz = new int[4, 4];
        int somaAbaixoDiagonal = 0;

        Console.WriteLine("Por favor, insira os valores para preencher a matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                somaAbaixoDiagonal += matriz[i, j];
            }
        }

        Console.WriteLine("\nElementos da diagonal principal:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }

        Console.WriteLine($"\n\nSoma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");
    }
}
