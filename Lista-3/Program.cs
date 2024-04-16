using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("||              Bem - Vindo            ||");
                Console.WriteLine("||             Lista 3 - ATP           ||");
                Console.WriteLine("||     Aluno: Victor Gomes De Miranda  ||");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Digite o Numero da questao que quer conferir: (1 a 10) ");
                int QUESTAO = int.Parse(Console.ReadLine());

                switch (QUESTAO)
                {
                    case 1:
                        int zeros = 0, positivo = 0, numNegativos = 0;
                        Console.WriteLine("Digite os valores inteiros (Escreva 01 para parar): ");
                        double nums;
                        do
                        {
                            nums = double.Parse(Console.ReadLine());
                            if (nums == 0)
                            {
                                zeros++;
                            }
                            else if (nums > 0)
                            {
                                positivo++;
                            }
                            else
                            {
                                numNegativos++;
                            }

                        } while (nums != 01);

                        Console.WriteLine($"Zeros: {zeros}");
                        Console.WriteLine($"Positivos: {positivo}");
                        Console.WriteLine($"Negativos: {numNegativos}");
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:


                        break;
                    case 7:
 
                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    case 10:

                        break;
                }
                Console.WriteLine("\n=========================================");
                Console.WriteLine("||                                      ||");
                Console.WriteLine("||  Deseja testar outra questão? (S/N)  ||");
                Console.WriteLine("||                                      ||");
                Console.WriteLine("========================================");
                char resposta = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                continuar = (resposta == 'S');
            }
            Console.Clear();
            Console.WriteLine("\n=========================================");
            Console.WriteLine("||                                      ||");
            Console.WriteLine("||   OBRIGADO POR RODA O MEU PROGRAMA   ||");
            Console.WriteLine("||                                      ||");
            Console.WriteLine("========================================");

        }
    }

}