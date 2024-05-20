using System;
public static class Exercicio2
{
    public static void Rodar()
    {
      Console.WriteLine("\nDigite o número de cidadãos:");
        int quantidadeCidadãos = Convert.ToInt32(Console.ReadLine());

        double somaSalarios = 0;
        int contadorPessoas = 0;

        for (int i = 0; i < quantidadeCidadãos; i++)
        {
            Console.WriteLine($"Digite o salário do cidadão {i + 1}:");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Digite o número de filhos do cidadão {i + 1}:");
            int numeroDeFilhos = Convert.ToInt32(Console.ReadLine());

            somaSalarios += salario;
            contadorPessoas++;
        }

        ExibirMediaSalarios(somaSalarios, contadorPessoas);
    }

    static void ExibirMediaSalarios(double somaSalarios, int contadorPessoas)
    {
        if (contadorPessoas > 0)
        {
            double mediaSalarios = somaSalarios / contadorPessoas;
            Console.WriteLine($"A média de salário da população é: {mediaSalarios:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }
    }
}