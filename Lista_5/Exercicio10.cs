using System;

class Exercicio10
{
    public static void Rodar()
    {
        int[,] M = new int[10, 10];

        Console.WriteLine("Preenchendo a matriz M(10,10):");
        PreencherMatriz(M);

        Console.WriteLine("\nMatriz Original M(10,10):");
        ExibirMatriz(M);

        TrocarLinhas(M, 1, 7); 
        Console.WriteLine("\nMatriz após troca da linha 2 com a linha 8:");
        ExibirMatriz(M);

        TrocarColunas(M, 3, 9); 
        Console.WriteLine("\nMatriz após troca da coluna 4 com a coluna 10:");
        ExibirMatriz(M);

        TrocarDiagonais(M);
        Console.WriteLine("\nMatriz após troca da diagonal principal com a diagonal secundária:");
        ExibirMatriz(M);

        TrocarLinhaComColuna(M, 4, 9); 
        Console.WriteLine("\nMatriz após troca da linha 5 com a coluna 10:");
        ExibirMatriz(M);
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

    static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }
    }

    static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }
    }

    static void TrocarDiagonais(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, n - 1 - i];
            matriz[i, n - 1 - i] = temp;
        }
    }

    static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna];
            matriz[i, coluna] = temp;
        }
    }
}
