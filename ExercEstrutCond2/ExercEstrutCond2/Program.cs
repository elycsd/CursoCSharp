using System;

namespace ExercEstrutCond2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número!");

            //Um número é par se o resto (Mod = %) da divisão
            //por 2 for igual a zero
            int num = int.Parse(Console.ReadLine())%2;

            if (num == 0) {
                Console.WriteLine("Número Par");
            }
            else {
                Console.WriteLine("Número Ímpar");
            }

        }
    }
}
