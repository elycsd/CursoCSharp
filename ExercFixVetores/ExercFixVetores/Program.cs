using System;

namespace ExercFixVetores {
    class Program {
        static void Main(string[] args) {
            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int aluguel = i + 1;
                Console.WriteLine("Aluguel #" + aluguel);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                if (quarto >= 0 && quarto <= 9) {
                    vect[quarto] = new Estudante(nome, email);
                    Console.WriteLine();
                }


            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i <= 9; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
