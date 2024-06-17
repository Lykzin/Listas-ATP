using System;

class Exercicio9
{
    public static void Rodar()
    {

        int[,] A = new int[4, 6];
        int[,] B = new int[4, 6];

        Console.WriteLine("Preenchendo a matriz A:");
        PreencherMatriz(A);
        Console.WriteLine("Preenchendo a matriz B:");
        PreencherMatriz(B);

        int[,] S = CalcularSoma(A, B);

        int[,] D = CalcularDiferenca(A, B);

        Console.WriteLine("\nMatriz A:");
        ExibirMatriz(A);
        Console.WriteLine("\nMatriz B:");
        ExibirMatriz(B);
        Console.WriteLine("\nMatriz S (Soma de A e B):");
        ExibirMatriz(S);
        Console.WriteLine("\nMatriz D (Diferença de A e B):");
        ExibirMatriz(D);
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] CalcularSoma(int[,] A, int[,] B)
    {
        int linhas = A.GetLength(0);
        int colunas = A.GetLength(1);
        int[,] S = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                S[i, j] = A[i, j] + B[i, j];
            }
        }

        return S;
    }

    static int[,] CalcularDiferenca(int[,] A, int[,] B)
    {
        int linhas = A.GetLength(0);
        int colunas = A.GetLength(1);
        int[,] D = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                D[i, j] = A[i, j] - B[i, j];
            }
        }

        return D;
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
}
