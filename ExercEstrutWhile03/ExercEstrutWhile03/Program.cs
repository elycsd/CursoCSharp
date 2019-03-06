using System;

namespace ExercEstrutWhile03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o numero referente ao combustivel de sua preferencia.");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - FIM");
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;
            int num = int.Parse(Console.ReadLine());

            while (num != 4) {
                if (num == 1) {
                    alcool++;
                }
                else if (num == 2) {
                    gasolina++;
                }
                else if (num == 3) {
                    diesel++;
                }
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

