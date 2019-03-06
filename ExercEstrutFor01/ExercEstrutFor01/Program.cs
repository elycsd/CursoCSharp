using System;

namespace ExercEstrutFor01 {
    class Program {
        static void Main(string[] args) {
            inicio:;
            Console.WriteLine("Digite um numero entre 1 e 1000");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 1000) {
                for (int i = 1; i <= num; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            }
            else {
                goto inicio;
            }
        }
    }
}
