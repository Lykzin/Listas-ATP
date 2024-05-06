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

                Console.WriteLine("Digite o Numero da questao que quer conferir: (1 a 11) ");
                int QUESTAO = int.Parse(Console.ReadLine());

                switch (QUESTAO)
                {
                    case 1:
                        double zeros=0, positivo=0, negativos=0;

                        Console.WriteLine("Digite quantos numeros você quer verificar: ");
                        int quantidadeNumeros = int.Parse(Console.ReadLine());

                        for (int i = 0 ; i < quantidadeNumeros; i++ )
                        {
                            Console.WriteLine($"Digite o número {i + 1}: ");
                            int num = int.Parse(Console.ReadLine());

                            if (num == 0)
                            {
                                zeros++;
                            }
                            else if (num > 0)
                            {
                                positivo++;
                            }
                            else
                            {
                                negativos++;
                            }
                        }
                        Console.WriteLine($"Quantidade de zeros: {zeros}");
                        Console.WriteLine($"Quantidade de números positivos: {positivo}");
                        Console.WriteLine($"Quantidade de números negativos: {negativos}");
                        break;

                    case 2:
                        double zero=0, positivos=0, negativo=0;

                        Console.WriteLine("Digite quantos numeros você quer verificar: ");
                        int qntNumeros = int.Parse(Console.ReadLine());

                        for (int i = 0 ; i < qntNumeros; i++ )
                        {
                            Console.WriteLine($"Digite o número {i + 1}: ");
                            int num = int.Parse(Console.ReadLine());

                            if (num == 0)
                            {
                                zero++;
                            }
                            else if (num > 0)
                            {
                                positivos++;
                            }
                            else
                            {
                                negativo++;
                            }                  
                        }
                            double soma = zero+positivos+negativo;
                            double PercentualZero = (zero/soma) * 100;
                            double PercentualPositivos = (positivos/soma) * 100;
                            double PercentualNegativo = (negativo/soma) * 100;

                        Console.WriteLine($"Quantidade de zeros: {zero} ({PercentualZero}% do total)");
                        Console.WriteLine($"Quantidade de números positivos: {positivos} ({PercentualPositivos}% do total)");
                        Console.WriteLine($"Quantidade de números negativos: {negativo} ({PercentualNegativo}% do total)");
                        break;

                    case 3:
                    int divisivelPor3e9 = 0;
                    int divisivelPor2e5 = 0;
                    int naoDivisivel = 0;

                    for (int i = 0; i < 10; i++) 
                    {
                        Console.Write($"Digite o {i + 1}º número: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 3 == 0 && num % 9 ==0)
                        {
                            Console.WriteLine($"{num} e divisivel por 3 e 9");
                            divisivelPor3e9++;
                        }
                        else if (num % 2 == 0 && num % 5 ==0)
                        {
                            Console.WriteLine($"{num} e divisivel por 2 e 5");
                            divisivelPor2e5++;
                        }
                        else{
                            Console.WriteLine($"{num} não e divisivel por nenhum das opçoes");
                            naoDivisivel++;         
                        }
                    }
                        Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divisivelPor3e9}");
                        Console.WriteLine($"Quantidade de números divisíveis por 2 e 5: {divisivelPor2e5}");
                        Console.WriteLine($"Quantidade de números não divisíveis por ambos: {naoDivisivel}");
                    
                        break;

                    case 4:                         
                        Console.Write("Insira um número natural para calcular o fatorial: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        if (numero < 0)
                        {
                            Console.WriteLine("Número inválido. Insira um número natural.");
                        }
                        else
                        {
                            long fatorial = 1;
                            for (int i = 1; i <= numero; i++)
                            {
                                fatorial *= i;
                            }
                            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
                        }
                        break;

                    case 5:
                    Console.WriteLine("Digite um valor inteiro e positivo para N:");
                    int N = int.Parse(Console.ReadLine());

                    if (N < 0)
                    {
                        Console.WriteLine("Número inválido. Por favor, insira um número inteiro e positivo.");
                    }
                    else
                    {
                        double E = 1; 
                        double fatorial = 1;

                        for (int i = 1; i <= N; i++)
                        {
                            fatorial *= i;
                            E += 1 / fatorial;
                        }
                    
                        Console.WriteLine($"O valor de E é: {E}");
                    }   
                        break;

                    case 6:
                         double somaSalario = 0;
                         int somaFilhos = 0;
                         double maiorSalario = 0;
                         int salarioAte100 = 0;

                        Console.WriteLine("Digite quantos Habitantes quer Avaliar:");
                        int numHabitantes = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numHabitantes; i++) 
                        {
                            Console.Write("Salário: R$");
                            double salario = double.Parse(Console.ReadLine());

                            if (salario>maiorSalario) 
                            {
                                maiorSalario = salario;
                                somaSalario += salario;
                            }
                            if (salario<=100)
                            salarioAte100++;

                            Console.WriteLine("Numeros de filhos: ");
                            int filhos = int.Parse(Console.ReadLine());

                            somaFilhos += filhos;
                        }

                        double mediaSalario = somaSalario / numHabitantes;
                        double mediaFilhos = somaFilhos / numHabitantes;
                        double Percentual100 = salarioAte100 / numHabitantes *100;

                        Console.WriteLine("\nResultados da pesquisa:");
                        Console.WriteLine("a) Média do salário da população: R$" + mediaSalario.ToString("0.00"));
                        Console.WriteLine("b) Média do número de filhos por habitante: " + mediaFilhos.ToString("0.00"));
                        Console.WriteLine("c) Maior salário: R$" + maiorSalario.ToString("0.00"));
                        Console.WriteLine("d) Percentual de pessoas com salário até R$100,00: " + Percentual100.ToString("0.00") + "%");
                        break;
                    case 7:
                    Console.WriteLine("Digite o valor de N: ");
                    int n = int.Parse(Console.ReadLine());

                    double Soma = 0;
                    for(int i = 0; i <= n; i++)
                    {
                        double termo = 1 / i;
                        Console.WriteLine($"Termo {i}: 1/{i} = {termo}");
                        Soma += termo;
                    }
                    Console.WriteLine("\nO valor final de S é: " + Soma);
                        break;

                    case 8:
                    int fibonacci = 40, contador = 0;

                    for (int i = 0; i < fibonacci; i*= 2)
                    {
                        contador += i + ( - 1 * (i - 1));
                        Console.WriteLine("O valor da série Fibonacci é : " + contador);
                    }
                        break;

                    case 9:

                        break;

                    case 10:
                    int lucro = 1, somalu = 0;
                    int contaluc1 = 0, contaluc2 = 0, contaluc3 = 0;

                    while (lucro > 0)
                    {
                        Console.WriteLine("Digite o valor do lucro");
                        lucro = int.Parse(Console.ReadLine());

                        somalu += lucro;   

                        if (lucro < ((lucro * 0.10) - lucro))
                        {
                            contaluc1++;
                            Console.WriteLine("A quantidade de mercadorias que tiveram o lucro menor que 10% é : " + contaluc1);
                        }
                        else if ((lucro >= ((lucro * 0.10) - lucro))||(lucro <= ((lucro * 0.20) - lucro)))
                        {
                            contaluc2++;
                            Console.WriteLine("A quantidade de mercadorias que tiveram o lucro entre 10% e 20% é : " + contaluc2);
                        }
                        else 
                        {
                            contaluc3++;
                            Console.WriteLine("A quantidade de mercadorias que tiveram o lucro maior que 20% é : " + contaluc3);
                        }

                        Console.WriteLine("A soma das vendas é de : " + somalu);
                    }
                        break;

                    case 11:
                    string votos;
                    int votacao, cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, vn = 0, veb = 0; // Cand (São os candidatos), Vn (É voto nulo) e Veb (Votos em brancos)

                    do {
                        Console.WriteLine("Você deseja vota em qual candidato (Digite 1 / 2 / 3 / 4), caso deseja votar nulo (Digite 5), mas caso deseja votar em branco (Digite 6)");
                        votacao = int.Parse(Console.ReadLine());

                        if (votacao == 1)
                        {
                            cand1++;
                        }
                        if (votacao == 2)
                        {
                            cand2++;
                        }
                        if (votacao == 3)
                        {
                            cand3++;
                        }
                        if (votacao == 4)
                        {
                            cand4++;
                        }
                        if (votacao == 5)
                        {
                            vn++;
                        }
                        if (votacao == 6)
                        {
                            veb++;
                        }
                        else
                        {
                            Console.WriteLine("Por favor digite uma das opções");
                        }

                        Console.WriteLine("Quantidades de votos para o Candidato1 : " + cand1);
                        Console.WriteLine("Quantidades de votos para o Candidato2 : " + cand2);
                        Console.WriteLine("Quantidades de votos para o Candidato3 : " + cand3);
                        Console.WriteLine("Quantidades de votos para o Candidato4 : " + cand4);
                        Console.WriteLine("Quantidades de votos nulos : " + vn);
                        Console.WriteLine("Quantidades de votos em branco : " + veb);

                        Console.WriteLine("Deseja continuar? (Sim/Não)(S/N)");
                        votos = Console.ReadLine();

                    }   while ((votos == "Sim")||(votos == "S"));
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
