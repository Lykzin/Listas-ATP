using System;

class Exercicio7
{
     public static void Rodar()
    {

        int[,] M = new int[5, 5];

        PreencherMatriz(M);

        Console.WriteLine("Matriz M:");
        ExibirMatriz(M);

        Console.WriteLine($"Soma da linha 4: {SomaLinha(M, 4)}");
        Console.WriteLine($"Soma da coluna 2: {SomaColuna(M, 2)}");
        Console.WriteLine($"Soma da diagonal principal: {SomaDiagonalPrincipal(M)}");
        Console.WriteLine($"Soma da diagonal secundária: {SomaDiagonalSecundaria(M)}");
        Console.WriteLine($"Soma de todos os elementos: {SomaTodosElementos(M)}");
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i,j] = random.Next(1, 11);
            }
        }
    }

    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int SomaLinha(int[,] matriz, int linha)
    {
        int soma = 0;
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            soma += matriz[linha, j];
        }
        return soma;
    }

    static int SomaColuna(int[,] matriz, int coluna)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, coluna];
        }
        return soma;
    }

    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, matriz.GetLength(1) - 1 - i];
        }
        return soma;
    }

    static int SomaTodosElementos(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }
}
