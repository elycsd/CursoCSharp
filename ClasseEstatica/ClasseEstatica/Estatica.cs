using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseEstatica
{
    public static class Estatica
    {
        public static string Nome { get; set; }

        public static void MostrarNome()
        {
            Console.WriteLine(Nome);
        }
    }
}
