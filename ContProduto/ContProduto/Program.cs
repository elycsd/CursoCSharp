using System;

namespace ContProduto {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);
            p.Nome = "T";

            Console.WriteLine(p.Nome);
        }
    }
}
