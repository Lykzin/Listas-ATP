using System;

class Exercicio4
{
    public static void Rodar()
    {
       
        int[] X = new int[10];
        int[] Y = new int[10];

        PreencherVetor(X, "X");
        PreencherVetor(Y, "Y");

        Console.WriteLine("Vetor X:");
        ExibirVetor(X);
        Console.WriteLine("Vetor Y:");
        ExibirVetor(Y);

        int[] Z = IntercalarVetores(X, Y);

        Console.WriteLine("Vetor Z intercalado:");
        ExibirVetor(Z);
    }

    static void PreencherVetor(int[] vetor, string nome)
    {
        Random random = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(1, 100); 
        }
    }
    static void ExibirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }

    static int[] IntercalarVetores(int[] X, int[] Y)
    {
        int[] Z = new int[X.Length + Y.Length];
        int j = 0;

        for (int i = 0; i < X.Length; i++)
        {
            Z[j++] = X[i]; 
            Z[j++] = Y[i]; 
        }

        return Z;
    }
}
