using System;

namespace ExercMatrizes02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero de linhas e colunas da matriz: ");
            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);
            int[,] mat = new int[m, n];

            Console.WriteLine();
            Console.WriteLine("Digite os {0} numeros de cada linha:", n);
            Console.WriteLine();
            for (int i = 0; i < m; i++) {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(line[j]);
                }
            }
            //denovo:
            Console.WriteLine();
            Console.Write("Digite um numero contido na matriz: ");
            int x = int.Parse(Console.ReadLine());
           // Console.WriteLine();
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine();
                        Console.WriteLine("{0} found in Position: (" + i + "," + j + "):", x);
                        if (i > 0) {
                            Console.Write("Up: " + mat[i - 1, j] + "; ");
                        }
                        if (j > 0) {
                            Console.Write ("Left: " + mat[i, j - 1] + "; ");
                        }
                        if (j < n - 1) {
                            Console.Write("Right: " + mat[i, j + 1] + "; ");
                        }
                        if (i < m - 1) {
                            Console.Write("Down: " + mat[i + 1, j] + "; ");
                        }
                    }
                }
                Console.WriteLine();
            }
            //goto denovo;
        }
    }
}
