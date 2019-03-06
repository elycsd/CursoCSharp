using System;
using System.Globalization;

namespace ExercEstrutSeq02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o raio do círculo");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double circunferencia = 2 * pi * raio;
            double area = pi * Math.Pow(raio, 2);
            double volume = pi * Math.Pow(raio, 3);

            Console.WriteLine();
            Console.WriteLine("A circunferência é: C = " + circunferencia.ToString("F4", CultureInfo.InvariantCulture) + "m");
            Console.WriteLine("A área do círculo é: A = " + area.ToString("F4", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine("O Volume da Esfera é: V = " + volume.ToString("F4", CultureInfo.InvariantCulture) + "m³");
            Console.WriteLine();
        }
    }
}
