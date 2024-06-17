using System;

class Exercicio5
{
    public static void Rodar()
    {
        int[] numerosSorteados = SortearNumeros();
        LerTentativas(numerosSorteados);
    }
    static int[] SortearNumeros()
    {
        Random random = new Random();
        int[] numeros = new int[3];
        
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(10, 51); 
        }

        return numeros;
    }
    static void LerTentativas(int[] numerosSorteados)
    {
        int tentativa;
        bool acertou = false;

        Console.WriteLine("Tente adivinhar um dos números sorteados (entre 10 e 50):");

        while (!acertou)
        {
            Console.Write("Digite sua tentativa: ");
            if (int.TryParse(Console.ReadLine(), out tentativa))
            {
                if (Array.Exists(numerosSorteados, numero => numero == tentativa))
                {
                    Console.WriteLine("Parabéns! Você acertou.");
                    acertou = true;
                }
                else
                {
                    Console.WriteLine("Errado! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, digite um número entre 10 e 50.");
            }
        }
    }
}
