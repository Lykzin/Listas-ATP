using System;

class Program
{
    static void Main()
    {
        Menu.ExibirMenu();
    }
}

public static class Menu
{
    public static void ExibirMenu()
    {
        while (true)
        {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
  _      _     _          _  _   
 | |    (_)   | |        | || |  
 | |     _ ___| |_ __ _  | || |_ 
 | |    | / __| __/ _` | |__   _|
 | |____| \__ | || (_| |    | |  
 |______|_|___/\__\__,_|    |_|  
                                                            
");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("||              Bem - Vindo            ||");
                Console.WriteLine("||             Lista 5 - ATP           ||");
                Console.WriteLine("||     Aluno: Victor Gomes De Miranda  ||");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Digite o Numero da questao que quer conferir: (1 a 10) ");
                int QUESTAO = int.Parse(Console.ReadLine());
    
            switch (QUESTAO)
            {
                case 0:
                    Console.WriteLine("Saindo...");
                    return;
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         __ 
 |  ____|                 /_/    (_)       /_ |
 | |__  __  _____ _ __ ___ _  ___ _  ___    | |
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \   | |
 | |____ >  |  __| | | (__| | (__| | (_) |  | |
 |______/_/\_\___|_|  \___|_|\___|_|\___/   |_|
                                               
                                               
");
                Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio1.Rodar();
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         ___  
 |  ____|                 /_/    (_)       |__ \ 
 | |__  __  _____ _ __ ___ _  ___ _  ___      ) |
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \    / / 
 | |____ >  |  __| | | (__| | (__| | (_) |  / /_ 
 |______/_/\_\___|_|  \___|_|\___|_|\___/  |____|
                                                 
                                                 
");
                    Console.ForegroundColor = ConsoleColor.Green;
                     Exercicio2.Rodar();
                    break;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         ____  
 |  ____|                 /_/    (_)       |___ \ 
 | |__  __  _____ _ __ ___ _  ___ _  ___     __) |
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \   |__ < 
 | |____ >  |  __| | | (__| | (__| | (_) |  ___) |
 |______/_/\_\___|_|  \___|_|\___|_|\___/  |____/ 
                                                  
                                                  
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio3.Rodar();
                    break;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         _  _   
 |  ____|                 /_/    (_)       | || |  
 | |__  __  _____ _ __ ___ _  ___ _  ___   | || |_ 
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \  |__   _|
 | |____ >  |  __| | | (__| | (__| | (_) |    | |  
 |______/_/\_\___|_|  \___|_|\___|_|\___/     |_|  
                                                   
                                                   
");
                    Console.ForegroundColor = ConsoleColor.Green;

                    break;
                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         _____ 
 |  ____|                 /_/    (_)       | ____|
 | |__  __  _____ _ __ ___ _  ___ _  ___   | |__  
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \  |___ \ 
 | |____ >  |  __| | | (__| | (__| | (_) |  ___) |
 |______/_/\_\___|_|  \___|_|\___|_|\___/  |____/ 
                                                  
                                                  
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio5.Rodar();
                    break;
                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _           __  
 |  ____|                 /_/    (_)         / /  
 | |__  __  _____ _ __ ___ _  ___ _  ___    / /_  
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \  | '_ \ 
 | |____ >  |  __| | | (__| | (__| | (_) | | (_) |
 |______/_/\_\___|_|  \___|_|\___|_|\___/   \___/ 
                                                  
                                                  
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio6.Rodar();
                    break;
                case 7:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         ______ 
 |  ____|                 /_/    (_)       |____  |
 | |__  __  _____ _ __ ___ _  ___ _  ___       / / 
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \     / /  
 | |____ >  |  __| | | (__| | (__| | (_) |   / /   
 |______/_/\_\___|_|  \___|_|\___|_|\___/   /_/    
                                                   
                                                   
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio7.Rodar();
                    break;
                case 8:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _          ___  
 |  ____|                 /_/    (_)        / _ \ 
 | |__  __  _____ _ __ ___ _  ___ _  ___   | (_) |
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \   > _ < 
 | |____ >  |  __| | | (__| | (__| | (_) | | (_) |
 |______/_/\_\___|_|  \___|_|\___|_|\___/   \___/ 
                                                  
                                                  
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio8.Rodar();
                    break;
                case 9:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _          ___  
 |  ____|                 /_/    (_)        / _ \ 
 | |__  __  _____ _ __ ___ _  ___ _  ___   | (_) |
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \   \__, |
 | |____ >  |  __| | | (__| | (__| | (_) |    / / 
 |______/_/\_\___|_|  \___|_|\___|_|\___/    /_/  
                                                  
                                                  
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio9.Rodar();
                    break;
                case 10:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
  ______                   __     _         __  ___  
 |  ____|                 /_/    (_)       /_ |/ _ \ 
 | |__  __  _____ _ __ ___ _  ___ _  ___    | | | | |
 |  __| \ \/ / _ | '__/ __| |/ __| |/ _ \   | | | | |
 | |____ >  |  __| | | (__| | (__| | (_) |  | | |_| |
 |______/_/\_\___|_|  \___|_|\___|_|\___/   |_|\___/ 
                                                     
                                                     
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Exercicio10.Rodar();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha um número de 0 a 5.");
                    break;
            }
        }
    }
}