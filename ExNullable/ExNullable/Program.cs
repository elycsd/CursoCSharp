using System;

namespace ExNullable {
    class Program {
        static void Main(string[] args) {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine();
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine();
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            Console.WriteLine();
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
        }
    }
}
