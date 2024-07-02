using System;

class Exercicio3
{
    public static void Rodar()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseCodificada = CodificarCesar(frase, 3);

        Console.WriteLine($"Frase codificada: {fraseCodificada}");
    }

    static string CodificarCesar(string frase, int deslocamento)
    {
        string resultado = "";

        foreach (char c in frase)
        {
            if (char.IsLetter(c))
            {
                char letraBase = char.IsUpper(c) ? 'A' : 'a';
                char letraCodificada = (char)((c + deslocamento - letraBase) % 26 + letraBase);
                resultado += letraCodificada;
            }
            else
            {
                resultado += c;
            }
        }

        return resultado.ToUpper();
    }
}
