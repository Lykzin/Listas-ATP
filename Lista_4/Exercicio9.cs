using System;

public class Exercicio9 {
    public static void Rodar() 
    {
        Console.WriteLine("\nDigite o número de alunos:");
        int numeroDeAlunos = int.Parse(Console.ReadLine());

        double mediaAprovados = CalcularMediaAprovados(numeroDeAlunos);

        Console.WriteLine($"A média das notas dos alunos aprovados é: {mediaAprovados:F2}");
    }

    static double CalcularMediaAprovados(int numeroDeAlunos)
    {
        int totalAprovados = 0;
        double somaNotas = 0;

        for (int i = 0; i < numeroDeAlunos; i++)
        {
            Console.WriteLine($"Digite a nota do aluno {i + 1}:");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                somaNotas += nota;
                totalAprovados++;
            }
        }

        if (totalAprovados > 0)
        {
            return somaNotas / totalAprovados;
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi aprovado.");
            return 0;
    }
  }
}