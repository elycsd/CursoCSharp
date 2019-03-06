using System;
using System.Collections.Generic;

namespace ExercFixConjuntos {
    class Program {
        static void Main(string[] args) {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos");
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos");
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("O curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos");
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(A);
            novo.UnionWith(B);
            novo.UnionWith(C);
            int alunos = 0;
            foreach (int obj in novo) {
                alunos++;
            }
            Console.WriteLine($"Total de alunos do professor Joaquim: {alunos}");
            Console.WriteLine();
            string lista = "";
            foreach (int item in novo) {
                lista += item + ", ";
            }
            lista = lista.Remove(lista.Length - 2);
            Console.WriteLine($"Alunos do prof. Joaquim: {lista}.");
        }
    }
}
