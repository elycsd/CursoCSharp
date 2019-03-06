using System;

namespace ExSwitch {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero do dia: ");
            string day = "";
            int x = int.Parse(Console.ReadLine());
            switch (x) {
                case 1:
                    day = "Sunday";
                        break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value.";
                    break;
            }
            Console.WriteLine("Day = " + day);
        }
    }
}
