using System;
using System.IO;

class Exercicio4
{
    public static void Rodar()
    {
        string caminhoArquivo = "soma_divisores.txt";

        try
        {
            string conteudo = File.ReadAllText(caminhoArquivo);

            int contadorA = 0;
            foreach (char c in conteudo)
            {
                if (c == 'a' || c == 'A') 
                {
                    contadorA++;
                }
            }

            Console.WriteLine($"A quantidade de caracteres 'a' no arquivo é: {contadorA}");
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
