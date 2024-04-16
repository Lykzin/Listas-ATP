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
                Console.WriteLine("||             Lista 2 - ATP           ||");
                Console.WriteLine("||     Aluno: Victor Gomes De Miranda  ||");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Digite o Numero da questao que quer conferir: (1 a 10) ");
                int QUESTAO = int.Parse(Console.ReadLine());

                switch (QUESTAO)
                {
                    case 1:
                        Console.WriteLine("\nDigite os 2 numeros: ");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());

                        if (num2 > num1)
                        {
                            Console.WriteLine("O maior numero é: " + num2);
                        }
                        else
                        {
                            Console.WriteLine("O maior numero é: " + num1);
                        };
                        break;

                    case 2:
                        Console.WriteLine("\nDigite o primeiro número inteiro:");
                        int numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número inteiro:");
                        int numero2 = int.Parse(Console.ReadLine());

                        int soma = numero1 + numero2;

                        if (soma >= 10)
                        {
                            soma += 5;
                        }
                        else
                        {
                            soma += 7;
                        }
                        Console.WriteLine("O resultado final é: " + soma);
                        break;

                    case 3:
                        Console.WriteLine("\nDigite o Coeficiente 'a':");
                        double a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o Coeficiente 'b': ");
                        double b = double.Parse(Console.ReadLine());

                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                Console.WriteLine("A equação é uma identidade: possui infinitas soluções.");
                            }
                            else
                            {
                                Console.WriteLine("A equação não tem solução.");
                            }
                        }
                        else
                        {
                            double raiz = -b / a;
                            Console.WriteLine($"A raiz da equação é: {raiz}");
                        }
                        break;

                    case 4:
                        Console.Write("\nDigite o ano de nascimento: ");
                        int anoNascimento = int.Parse(Console.ReadLine());

                        int anoAtual = 2024;

                        Console.Write("Você já fez aniversário este ano? (S/N): ");
                        char fezAniversario = char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();


                        int idade;
                        if (fezAniversario == 'S')
                        {
                            idade = anoAtual - anoNascimento;
                        }
                        else
                        {
                            idade = anoAtual - anoNascimento - 1;
                        }

                        if (idade >= 18)
                        {
                            Console.WriteLine("Você já pode obter a Carteira de Habilitação.");
                        }
                        else
                        {
                            Console.WriteLine("Você ainda não pode obter a Carteira de Habilitação.");
                        }

                        Console.WriteLine($"Sua idade é: {idade} anos.");
                        break;

                    case 5:
                        Console.WriteLine("\nDigite a nota do aluno: ");
                        double nota = double.Parse(Console.ReadLine());

                        if (nota > 10 || nota < 0)
                        {
                            Console.WriteLine("Nota invalida");
                        }
                        else if (nota >= 8 && nota <= 10)
                        {
                            Console.WriteLine("Nota Otima");
                        }
                        else if (nota >= 7 && nota < 8)
                        {
                            Console.WriteLine("Nota BOM");
                        }
                        else if (nota >= 5 && nota < 7)
                        {
                            Console.WriteLine("Nota Regular");
                        }
                        else if (nota < 5)
                        {
                            Console.WriteLine("Nota insatisfatória");
                        }
                        break;

                    case 6:
                        double hotel, desc, diaria, hotelp = 75, valordesc1, valordesc2, diferenca;

                        Console.WriteLine("Digite o valor da diaria: ");
                        hotel = double.Parse(Console.ReadLine());
                        diaria = hotel - (hotel * 0.25);
                        valordesc1 = (hotelp * 0.80)*diaria;
                        valordesc2 = (hotelp * 0.50) * hotel;

                        if (valordesc1 > valordesc2){
                            diferenca = valordesc1 - valordesc2;
                            Console.WriteLine("O valor da diferença é :"+ diferenca);
                        }
                        else{
                            diferenca = valordesc1 - valordesc2;
                            Console.WriteLine("O valor da diferença é :"+ diferenca);
                        }
                        Console.WriteLine("O valor da diaria com desconto: "+diaria);
                        Console.WriteLine("O valor da diaria com desconto de 80%: "+valordesc1);
                        Console.WriteLine("O valor da diaria com desconto de 50%: "+valordesc2);

                        break;
                    case 7:
                        double y = 0;

                        Console.WriteLine("\nDigite o Valor de X: ");
                        double x = double.Parse(Console.ReadLine());

                        if (x <= 1)
                        {
                            y = 1;
                            Console.WriteLine($"o Valor de Y é: {y}");
                        }
                        else if (x < 1 && x <= 2)
                        {
                            y = 2;
                            Console.WriteLine($"o Valor de Y é: {y}");
                        }
                        else if (x < 2 && x <= 3)
                        {
                            y = Math.Pow(x, 2);
                            Console.WriteLine($"o Valor de Y é: {y}");
                        }
                        else if (x > 3)
                        {
                            y = Math.Pow(x, 3);
                            Console.WriteLine($"o Valor de Y é: {y}");
                        }
                        break;

                    case 8:
                        Console.WriteLine("\nDigite o Salario do Fucionario: ");
                        double salarioAtual = double.Parse(Console.ReadLine());

                        Console.WriteLine("\n======================================================");
                        Console.WriteLine("|| Digite qual opçao de ajuste Salarial você quer:  ||");
                        Console.WriteLine("|| A = aumento de 8% no salário                     ||");
                        Console.WriteLine("|| B = aumento de 11% no salário                    ||");
                        Console.WriteLine("|| C = aumento fixo no salário                      ||");
                        Console.WriteLine("======================================================");
                        Console.Write("OPÇÃO: ");
                        char opcao = char.Parse(Console.ReadLine());

                        double novoSalario = 0;

                        switch (opcao)
                        {
                            case 'A':
                                novoSalario = salarioAtual * 1.08;
                                break;
                            case 'B':
                                novoSalario = salarioAtual * 1.11;
                                break;
                            case 'C':
                                if (salarioAtual <= 1000)
                                {
                                    novoSalario = salarioAtual + 350;
                                }
                                else if (salarioAtual > 1000)
                                {
                                    novoSalario = salarioAtual + 200;
                                }
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                return;
                        }
                        Console.WriteLine($"Novo salário: R${novoSalario:F2}");
                        break;

                    case 9:
                        Console.WriteLine("\nESCREVA O SINAL: ");
                        char sinal = char.Parse(Console.ReadLine());

                        switch (sinal)
                        {
                            case '<':
                                Console.WriteLine("\nSINAL DE MENOR");
                                break;
                            case '>':
                                Console.WriteLine("\nSINAL DE MAIOR");
                                break;
                            case '=':
                                Console.WriteLine("\nSINAL DE IGUAL");
                                break;
                            default:
                                Console.WriteLine("\nOUTRO SINAL");
                                break;
                        }
                        break;

                    case 10:
                        Console.WriteLine("\nQual a velocidade Maxima Permitida? ");
                        int velocidadeMAX = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual Velocidade do Motorista? ");
                        int velocidade = int.Parse(Console.ReadLine());

                        int multa = 0;
                        int diferençaDeVelocidade = 0;

                        if (velocidade <= velocidadeMAX)
                        {
                            Console.WriteLine("Motorista respeito a Lei!");
                        }
                        else
                        {
                            diferençaDeVelocidade = velocidade - velocidadeMAX;

                            if (diferençaDeVelocidade <= 10)
                            {
                                multa = 50;
                            }
                            else if (diferençaDeVelocidade <= 30)
                            {
                                multa = 100;
                            }
                            else
                            {
                                multa = 200;
                            }
                            Console.WriteLine("\nO motorista ultrapassou a velocidade máxima permitida.");
                            Console.WriteLine($"Multa a ser cobrada: R$ {multa:F2}");
                        }
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
