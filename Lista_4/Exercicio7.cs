using System;

public class Exercicio7 
{
    public static void Rodar() 
    {
        Console.WriteLine("\nDigite o número de alunos (N):");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite a média final do aluno {i + 1}:");
            double media = double.Parse(Console.ReadLine());

            IdentificarConceito(media);
        }
    }

    static void IdentificarConceito(double media)
    {
        char conceito;

        if (media >= 90)
        {
            conceito = 'A';
        }
        else if (media >= 80)
        {
            conceito = 'B';
        }
        else if (media >= 70)
        {
            conceito = 'C';
        }
        else if (media >= 60)
        {
            conceito = 'D';
        }
        else if (media >= 40)
        {
            conceito = 'E';
        }
        else
        {
            conceito = 'F';
        }

        Console.WriteLine($"Conceito: {conceito}");
    }
}