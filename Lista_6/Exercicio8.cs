using System;
using System.IO;

class Exercicio8
{
    public static void Rodar()
    {
        Console.WriteLine("Digite a quantidade de veículos:");
        int veiculos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do aluguel por veículo:");
        double valorAluguel = double.Parse(Console.ReadLine());

        double faturamentoMensal = (veiculos * valorAluguel) / 3;
        double faturamentoAnual = faturamentoMensal * 12;

        double multaMensal = (faturamentoMensal / 10) * 0.2;
        double manutencaoAnual = (veiculos * 0.02) * 600;

        Console.WriteLine($"Faturamento Anual: {faturamentoAnual}");
        Console.WriteLine($"Valor ganho com multas no mês: {multaMensal}");
        Console.WriteLine($"Valor gasto com manutenção anual: {manutencaoAnual}");

        using (StreamWriter writer = new StreamWriter("resultado.txt"))
        {
            writer.WriteLine($"Faturamento Anual: {faturamentoAnual}");
            writer.WriteLine($"Valor ganho com multas no mês: {multaMensal}");
            writer.WriteLine($"Valor gasto com manutenção anual: {manutencaoAnual}");
        }
    }
}
