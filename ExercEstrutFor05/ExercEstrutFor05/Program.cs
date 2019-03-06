using System;

namespace ExercEstrutFor05 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero para calcular o fatorial");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= n; i++) {
                fat *= i;
            }
            Console.WriteLine(fat);
        }
    }
}
