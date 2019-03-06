using System;

namespace ExCondTernario {
    class Program {
        static void Main(string[] args) {
            double preco = 34.5;
            //Sintaxe: (condição) ? valor_se_verdaeiro : valor_se_falso;
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.5;
            Console.WriteLine("Desconto: " + desconto);
        }
    }
}
