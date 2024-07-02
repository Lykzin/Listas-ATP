using System;
using System.IO;

class Exercicio5
{
    public static void Rodar()
    {
        string caminhoArquivo = "soma_divisores.txt";

        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            Console.WriteLine("Conteúdo do arquivo:");
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine($"\nO arquivo possui {linhas.Length} linhas.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"O arquivo '{caminhoArquivo}' não foi encontrado.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro: {e.Message}");
        }
    }
}
