using System;

namespace ExercEstrutCond4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite as horas inicial e final do jogo:");
            string[] valores = Console.ReadLine().Split(' ');
            int horainicial = int.Parse(valores[0]);
            int horafinal = int.Parse(valores[1]);

            int duracao;
            if (horafinal > horainicial) {
                duracao = horafinal - horainicial;
            }
            else {
                duracao = 24 - horainicial + horafinal;
            }

            Console.WriteLine("O jogo durou " + duracao + " horas.");
        }
    }
}
