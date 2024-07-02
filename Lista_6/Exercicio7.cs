using System;
using System.IO;

class Exercicio7
{
    public static void Rodar()
    {
        Console.WriteLine("Digite a quantidade de letras (N):");
        int N = int.Parse(Console.ReadLine());

        string caminhoArquivo = "letras.txt";

        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Digite a letra {i + 1}:");
                char letra = char.Parse(Console.ReadLine());
                writer.Write(letra);
            }
        }

        string conteudo = File.ReadAllText(caminhoArquivo);
        int contadorVogais = 0;
        string vogais = "aeiouAEIOU";

        foreach (char c in conteudo)
        {
            if (vogais.Contains(c))
            {
                contadorVogais++;
            }
        }

        Console.WriteLine($"A quantidade de vogais é: {contadorVogais}");
    }
}
