using System;
using System.IO;

class Exercicio6
{
    public static void Rodar()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Divisores de {numero}:");
        int somaDivisores = 0;
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
                somaDivisores += i;
            }
        }

        string caminhoArquivo = "soma_divisores.txt";
        File.WriteAllText(caminhoArquivo, $"A soma dos divisores de {numero} é: {somaDivisores}");

        Console.WriteLine($"A soma total dos divisores foi salva no arquivo '{caminhoArquivo}'.");
    }
}
