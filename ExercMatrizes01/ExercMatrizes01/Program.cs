using System;

namespace ExercMatrizes01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a ordem da matriz: ");
            /*n será a ordem da matriz*/
            int n = int.Parse(Console.ReadLine());

            /*Instanciando uma nova matriz de n linhas e n colunas(quadrada)*/
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                //Console.WriteLine("Digite os elementos da linha " + (i + 1) + ":") ;
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            //usando o foreach para percorrer os objetos
            int a = 0;
            foreach (int obj in mat) {
                if (obj < 0) {
                    a++;
                }
            }
            Console.WriteLine("Negative numbers(foreach): " + a);

            //usando o for para percorrer os objetos
            int b = 0;
            //for para percorrer as linhas
            for (int i = 0; i < n; i++) {
                //for para percorrer as colunas
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        b++;
                    }
                }
            }
            Console.WriteLine("Negative numbers(for): " + b);
        }
    }
}
