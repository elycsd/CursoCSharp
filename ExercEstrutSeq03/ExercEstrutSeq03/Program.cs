using System;

namespace ExercEstrutSeq03 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero C: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero D: ");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int diferenca = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + diferenca);
            Console.WriteLine();
        }
    }
}
