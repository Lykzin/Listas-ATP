using System;

class Program
{
    static void LISTAS()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n=========================================");
        Console.WriteLine("||     QUAL LISTA VOCÊ QUER ABRIR?      ||");
        Console.WriteLine("||                                      ||");
        Console.WriteLine("||       LISTA 1  -  Expressões         ||");
        Console.WriteLine("||       LISTA 2  -  Condicional        ||");
        Console.WriteLine("||                                      ||");
        Console.WriteLine("========================================");
        Console.WriteLine("\n");
        int escolhaLista = int.Parse(Console.ReadLine());

        if (escolhaLista == 1)
        {
            ExecutarLista1();
        }
        else if (escolhaLista == 2)
        {
            ExecutarLista2();
        }
        else
        {
            Console.WriteLine("Escolha inválida. Encerrando o programa.");
        }
    }
    static void ExecutarLista1()
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

                        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
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


    static void ExecutarLista2()
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

