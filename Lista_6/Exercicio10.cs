using System;
using System.IO;
using System.Linq;

class Exercicio10
{
    public static void Rodar()
    {
        string caminhoArquivo = "numeros.txt";

        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            double[] numeros = linhas.Select(double.Parse).ToArray();

            double valorMaximo = numeros.Max();
            double valorMinimo = numeros.Min();
            double media = numeros.Average();

            Console.WriteLine($"Valor máximo: {valorMaximo}");
            Console.WriteLine($"Valor mínimo: {valorMinimo}");
            Console.WriteLine($"Média: {media}");
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
