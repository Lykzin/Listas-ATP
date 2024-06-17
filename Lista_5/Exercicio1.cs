using System;

class Exercicio1
{
    public static void Rodar()
    {
        int[] vetor = new int[20];
        LerElementosVetor(vetor);
        var (menorElemento, posicao) = EncontrarMenorElemento(vetor);
        ExibirResultado(menorElemento, posicao);
    }

    static void LerElementosVetor(int[] vetor)
    {
        Console.WriteLine("Digite os 20 elementos do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static (int menorElemento, int posicao) EncontrarMenorElemento(int[] vetor)
    {
        int menorElemento = vetor[0];
        int posicao = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menorElemento)
            {
                menorElemento = vetor[i];
                posicao = i;
            }
        }

        return (menorElemento, posicao);
    }

    static void ExibirResultado(int menorElemento, int posicao)
    {
        Console.WriteLine("O menor elemento de N é: {0} e sua posição dentro do vetor é: {1}", menorElemento, posicao);
    }
}
