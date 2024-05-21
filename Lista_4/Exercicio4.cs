using System;
public static class Exercicio4
{
        public static void Rodar()
    {
         while (true)
        {
            Console.WriteLine("Digite os três valores dos lados do triângulo (X Y Z) ou 'sair' para encerrar:");
            
            double x = LerDouble();
            double y = LerDouble();
            double z = LerDouble();
            
            if (x == -1 || y == -1 || z == -1)
                break;

            VerificarTriangulo(x, y, z);
        }
    }

    static double LerDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                return valor;
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número válido ou 'sair' para encerrar:");
                if (Console.ReadLine().ToLower() == "sair")
                    return -1;
            }
        }
    }

    static void VerificarTriangulo(double x, double y, double z)
    {
        if (x < y + z && y < x + z && z < x + y)
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo.");
        }
    }
}

