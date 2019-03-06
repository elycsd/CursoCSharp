using System;

namespace ExercEstrutFor07 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero inteiro positivo.");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                int quad = i * i;
                int cub = quad * i;
                Console.WriteLine(i + " " + quad + " " + cub);
            }
        }
    }
}
