using System;

class Exercicio6
{
   public static void Rodar()
    {

        int[] temperaturas = new int[31];

        PreencherTemperaturas(temperaturas);

        Console.WriteLine("Temperaturas registradas em outubro:");
        ExibirVetor(temperaturas);

        int menorTemperatura = CalcularMenorTemperatura(temperaturas);
        int maiorTemperatura = CalcularMaiorTemperatura(temperaturas);
        Console.WriteLine($"Menor temperatura: {menorTemperatura}°C");
        Console.WriteLine($"Maior temperatura: {maiorTemperatura}°C");

        double temperaturaMedia = CalcularTemperaturaMedia(temperaturas);
        Console.WriteLine($"Temperatura média: {temperaturaMedia:F2}°C");

        int diasAbaixoDaMedia = ContarDiasAbaixoDaMedia(temperaturas, temperaturaMedia);
        Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoDaMedia}");
    }

    static void PreencherTemperaturas(int[] temperaturas)
    {
        Random random = new Random();
        for (int i = 0; i < temperaturas.Length; i++)
        {
            temperaturas[i] = random.Next(15, 41); 
        }
    }
    static void ExibirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
    static int CalcularMenorTemperatura(int[] temperaturas)
    {
        int menor = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < menor)
            {
                menor = temperaturas[i];
            }
        }
        return menor;
    }
    static int CalcularMaiorTemperatura(int[] temperaturas)
    {
        int maior = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > maior)
            {
                maior = temperaturas[i];
            }
        }
        return maior;
    }

    static double CalcularTemperaturaMedia(int[] temperaturas)
    {
        int soma = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }
        return (double)soma / temperaturas.Length;
    }

    static int ContarDiasAbaixoDaMedia(int[] temperaturas, double media)
    {
        int contador = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < media)
            {
                contador++;
            }
        }
        return contador;
    }
}
