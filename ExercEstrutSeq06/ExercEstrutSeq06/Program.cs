using System;

namespace ExercEstrutSeq06 {
    class Program {
        static void Main(string[] args) {
            inicio:
            Console.WriteLine("Digite os valores A, B e C: ");
            string[] dados = Console.ReadLine().Split(' ');
            double A = double.Parse(dados[0]);
            double B = double.Parse(dados[1]);
            double C = double.Parse(dados[2]);
            double pi = 3.14159;

            double triangulo = (A * C) / 2;
            double circulo = pi * C*C;
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine();
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
            goto inicio;

        }
    }
}
