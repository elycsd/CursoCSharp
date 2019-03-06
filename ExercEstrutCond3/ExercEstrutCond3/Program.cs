using System;

namespace ExercEstrutCond3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o Numero inteiro A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o Numero inteiro B: ");
            int B = int.Parse(Console.ReadLine());

            //Dois números são múltiplos se a divisão do maior pelo menor
            //tiver resto igual a zero

            if(A%B == 0 || B%A == 0) {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}
