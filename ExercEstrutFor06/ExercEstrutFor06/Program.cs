﻿using System;

namespace ExercEstrutFor06 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero para ver seus divisores");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
