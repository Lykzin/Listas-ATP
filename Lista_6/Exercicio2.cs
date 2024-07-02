using System;

class Exercicio2
{
    public static void Rodar()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseSemVogais = RemoverVogais(frase);

        Console.WriteLine($"Frase sem vogais: {fraseSemVogais}");
    }

    static string RemoverVogais(string frase)
    {
        string vogais = "aeiouAEIOU";
        string resultado = "";

        foreach (char c in frase)
        {
            if (!vogais.Contains(c))
            {
                resultado += c;
            }
        }

        return resultado;
    }
}
