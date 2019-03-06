using System;
using System.Globalization;

namespace ExercEncapsulamento {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Digite o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string nomeTit = Console.ReadLine();

            Console.Write("Realizar deposito inicial (S/N)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 's') {
                Console.Write("Digite o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, nomeTit, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numConta, nomeTit);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
