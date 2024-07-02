using System;

class Exercicio1
{
    public static void Rodar()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int contadorEspacos = 0;

        foreach (char c in frase)
        {
            if (c == ' ')
            {
                contadorEspacos++;
            }
        }

        Console.WriteLine($"A frase contém {contadorEspacos} espaços em branco.");
    }
}
