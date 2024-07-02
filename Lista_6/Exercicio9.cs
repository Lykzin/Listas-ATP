using System;
using System.IO;

class Exercicio9
{
    public static void Rodar()
    {
        string caminhoArquivo = "alunos.txt";

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Inserir dados de aluno");
            Console.WriteLine("2. Ler dados de alunos");
            Console.WriteLine("3. Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
                {
                    Console.WriteLine("Digite a matrícula do aluno:");
                    string matricula = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do aluno:");
                    string telefone = Console.ReadLine();
                    writer.WriteLine($"{matricula},{telefone}");
                }
            }
            else if (opcao == 2)
            {
                if (File.Exists(caminhoArquivo))
                {
                    string[] linhas = File.ReadAllLines(caminhoArquivo);
                    Console.WriteLine("Dados dos alunos:");
                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split(',');
                        Console.WriteLine($"Matrícula: {dados[0]}, Telefone: {dados[1]}");
                    }
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado.");
                }
            }
            else if (opcao == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}
