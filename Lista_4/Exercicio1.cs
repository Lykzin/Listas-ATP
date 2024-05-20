using System;

public class Exercicio1{
  public static void Rodar(){
    Console.WriteLine("\nDigite quantos alunos são: ");
    int N = int.Parse(Console.ReadLine());

    for(int i = 0 ; i < N; i++) {
        Console.WriteLine($"Aluno {i + 1}:");
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

          Console.Write("Digite 'A' para média aritmética ou 'P' para média ponderada: ");
          char letra = char.Parse(Console.ReadLine());

          CalcularMedia(nota1, nota2, nota3, letra);
    }
  }
  static void CalcularMedia (double nota1, double nota2, double nota3, char letra) {
    double media;
    if (letra == 'A' || letra == 'a') {
      media = (nota1+nota2+nota3)/3;
      Console.WriteLine($"A média aritmética é {media}");
    }
    else if (letra == 'P' || letra == 'p') {
      media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
      Console.WriteLine($"A média ponderada é {media}");
    }
    else{
      Console.WriteLine("Letra Invalida");
    }
  }
}
