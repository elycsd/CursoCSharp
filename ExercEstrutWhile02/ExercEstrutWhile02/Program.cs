using System;

namespace ExercEstrutWhile02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite as coordenadas x e y: ");
            string[] coord = Console.ReadLine().Split(' ');
            int x = int.Parse(coord[0]);
            int y = int.Parse(coord[1]);

            while(x != 0 && y != 0) {
                if(x > 0 && y > 0) {
                    Console.WriteLine("O ponto pertence ao primeiro quadrante.");
                }
                else if(x>0 && y<0){
                    Console.WriteLine("O ponto pertence ao quarto quadrante.");
                }
                else if(x<0 && y < 0) {
                    Console.WriteLine("O ponto pertence ao terceiro quadrante.");
                }
                else {
                    Console.WriteLine("O ponto pertence ao segundo quadrante.");
                }
                coord = Console.ReadLine().Split(' ');
                x = int.Parse(coord[0]);
                y = int.Parse(coord[1]);
            }

        }
    }
}
