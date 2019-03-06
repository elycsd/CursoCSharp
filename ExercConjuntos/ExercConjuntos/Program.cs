using System;
using System.Collections.Generic;

namespace ExercConjuntos {
    class Program {
        static void Main(string[] args) {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            //B.Remove(4); remover um item

            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            foreach (int x in B) {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("Digite um valor inteiro: ");
            //int n = int.Parse(Console.ReadLine());

            //Verificar se um numero pertence ao conjunto
            //if (B.Contains(n)) {
            //    Console.WriteLine($"{n} pertence ao conjunto B");
            //}
            //else {
            //    Console.WriteLine($"{n} não pertence ao conjunto B");
            //}

            /*Subtração ou diferença de conjuntos*/
            //A.ExceptWith(B);
            //foreach (int x in A) {
            //    Console.WriteLine(x);
            //}
            /*União de conjuntos*/
            //A.UnionWith(B);
            //foreach (int x in A) {
            //    Console.WriteLine(x);
            //}
            /*Intersecção de conjuntos*/
            A.IntersectWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }
        }
    }
}
