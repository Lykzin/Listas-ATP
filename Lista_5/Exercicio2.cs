using System;

class Exercicio2 
{
    public static void Rodar()
    {
        double [] notas = new double [10];
        PreencherNotas(notas);
        CalcularMediaEContarAcimaDaMedia(notas);
    }

    static void PreencherNotas (double [] notas) 
    {
        Console.WriteLine("Digite a nota dos 10 alunos");
        for(int i = 0; i <notas.Length; i++) 
        {
            Console.Write($"Nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
    }
    static void CalcularMediaEContarAcimaDaMedia(double[] notas) 
    {
        double soma = 0;
        foreach(double nota in notas) 
            soma+=nota;

        double media = soma/notas.Length;
        int contAcimaMedia = 0;

        foreach(double nota in notas) 
        {
            if(nota > media)
            {
                contAcimaMedia++;
            }
        }
        Console.WriteLine($"A média da turma é: {media:F2}");
        Console.WriteLine($"{contAcimaMedia} alunos obtiveram nota acima da média.");
    }
}