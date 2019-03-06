using System;

namespace ExercEstrutWhile01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002) {
                Console.WriteLine("Senha Invalida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
