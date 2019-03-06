using System;

namespace ExercEstrutSeq01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.WriteLine("SOMA = " + soma);

        }
    }
}
