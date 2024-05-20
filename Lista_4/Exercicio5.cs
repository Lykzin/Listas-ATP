using System;
public static class Exercicio5
{
    public static void Rodar()
    {
        Console.WriteLine("\nDigite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        int mdc = CalcularMDC(numero1, numero2);
        Console.WriteLine($"O Máximo Divisor Comum de {numero1} e {numero2} é: {mdc}");
    }

    static int CalcularMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}