using System;

namespace ExercEstrutWhile {
    class Program {
        static void Main(string[] args) {
            //versão de resposta
            inicio:;
            Console.Write("Digite a Senha: ");
            string senha = Console.ReadLine();
            while (senha == "2002") {
                Console.WriteLine("Acesso Permitido");
                goto fim;
            }
            Console.WriteLine("Senha Inválida");
            goto inicio;
            fim:;
        }
    }
}
