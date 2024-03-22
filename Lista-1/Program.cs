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
                Console.WriteLine("||             Lista 1 - ATP           ||");
                Console.WriteLine("||     Aluno: Victor Gomes De Miranda  ||");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Digite o Numero da questao que quer conferir: (1 a 8) ");
                int QUESTAO = int.Parse(Console.ReadLine());

                switch (QUESTAO)
                {
                    case 1:
                        double altura, Base, diagonal, area, perimetro;
                        Console.WriteLine("\nDigite a base e a altura do retângulo:");
                        Base = double.Parse(Console.ReadLine());
                        altura = double.Parse(Console.ReadLine());

                        diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(altura, 2));
                        area = Base * altura;
                        perimetro = 2 * (Base + altura);

                        Console.WriteLine("A área do retângulo é: " + area);
                        Console.WriteLine("O perímetro do retângulo é: " + perimetro);
                        Console.WriteLine($"A diagonal do retângulo é: {diagonal:F2}");
                        break;

                    case 2:
                        Console.WriteLine("\nDigite o valor do primeiro cateto: ");
                        double cateto1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor do segundo cateto: ");
                        double cateto2 = double.Parse(Console.ReadLine());

                        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2)+Math.Pow(cateto2, 2));
                        Console.WriteLine($"A hipotenusa do triângulo retângulo é: {hipotenusa:F2}");
                        break;

                    case 3:
                        double sm = 0, kilowatt = 0, umkilowatt = 0, vp = 0, desconto = 0;

                        Console.WriteLine("\nDigite o valor do salario minimo e quilowatts");
                        sm = double.Parse(Console.ReadLine());
                        kilowatt = double.Parse(Console.ReadLine());
                        umkilowatt = sm / 7;
                        Console.WriteLine("O valor de cada quilowatt é: " + umkilowatt);
                        vp = umkilowatt * kilowatt;
                        Console.WriteLine("O valor a ser pago é: " + vp);
                        desconto = vp * 0.9;
                        Console.WriteLine("O valor a ser pago com desconto é: " + desconto);
                        break;

                    case 4:
                        Console.WriteLine("\nDigite o valor de X1");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de X2");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de Y1");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de Y2");
                        int y2 = int.Parse(Console.ReadLine());

                        double resultado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
     
                        Console.WriteLine($"O resultado é : {resultado}");
                        break;

                    case 5:
                        double p, i, n, rendimento;

                        Console.WriteLine("\nDigite o valor da aplicação mensal (p): ");
                        p = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a taxa (i): ");
                        i = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o número de meses (n): ");
                        n = double.Parse(Console.ReadLine());

                        rendimento = p * ((Math.Pow((1 + i), n)) - 1) / i;

                        Console.WriteLine($"O rendimento é: {rendimento:F2}");
                        break;

                    case 6:
                        double A, B, temp;
                        Console.WriteLine("\nDigite o valor de A: ");
                        A = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de B:  ");
                        B = double.Parse(Console.ReadLine());

                        temp = A;
                        A = B;
                        B = temp;

                        Console.WriteLine("O valor de A é: " + A);
                        Console.WriteLine("O valor de B é: " + B);
                        break;

                    case 7:

                        Console.WriteLine("\nDigite o numero de dias sem acidentes na empresa: ");
                        int dias = int.Parse(Console.ReadLine());
                        int anos = dias / 365;
                        int meses = (dias % 365) / 30;
                        int diasRestantes = (dias % 365) % 30;

                        Console.WriteLine("A empresa tem " + anos + " anos, " + meses + " meses e " + diasRestantes + " dias sem acidentes");

                        break;
                    case 8:
                        int num, C, D, U, numInverso, soma, SomaMult, NumVerificador;

                        Console.WriteLine("\nDigite um número de 3 dígitos: ");
                        num = int.Parse(Console.ReadLine());

                        C = num / 100;
                        D = (num % 100) / 10;
                        U = num % 10;

                        numInverso = U * 100 + D * 10 + C;

                        soma = num + numInverso;

                        SomaMult = (C * 0) + (D * 1) + (U * 2);

                        NumVerificador = SomaMult % 10;

                        Console.WriteLine("Número: " + num);
                        Console.WriteLine("Número invertido: " + numInverso);
                        Console.WriteLine("Soma do número e número invertido: " + soma);
                        Console.WriteLine("A soma da multiplicação MCDU: " + SomaMult);
                        Console.WriteLine("O dígito verificador: " + NumVerificador);
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