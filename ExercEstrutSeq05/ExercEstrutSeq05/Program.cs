using System;
using System.Globalization;

namespace ExercEstrutSeq05 {
    class Program {
        static void Main(string[] args) {
            inicio:
            Console.Write("Digite os dados da primeira peça: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(peca1[0]);
            int qt1 = int.Parse(peca1[1]);
            double preco1 = double.Parse(peca1[2]);

            Console.Write("Digite os dados da segunda peça: ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(peca2[0]);
            int qt2 = int.Parse(peca2[1]);
            double preco2 = double.Parse(peca2[2]);

            double total = qt1 * preco1 + qt2 * preco2;
            Console.WriteLine(cod1 + " " + qt1 + " " + preco1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(cod2 + " " + qt2 + " " + preco2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            goto inicio;
        }
    }
}
