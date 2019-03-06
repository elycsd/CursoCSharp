using System;

namespace ExercEstrutFor04 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de divisões.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] num = Console.ReadLine().Split(' ');
                double x = double.Parse(num[0]);
                double y = double.Parse(num[1]);

                if (y != 0) {
                    double div = x / y;
                    Console.WriteLine(div.ToString("F1"));
                }
                else {
                    Console.WriteLine("Divisão impossivel");
                }
            }
        }
    }
}
