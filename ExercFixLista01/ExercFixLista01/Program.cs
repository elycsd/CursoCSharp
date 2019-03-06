using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercFixLista01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            /*Criando uma lista de objetos da classe Employee*/
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                /*Após ler os dados de Empoyee, adicionar à lista criando uma 
                 nova instancia de Employee passando os dados como parametros
                 no construtor.*/
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }
            Console.Write("Enter the employee id that will have salary increase: ");
            /*Criando um objeto int para receber o Id e depois servir de parametro para buscar na lista*/
            int searchId = int.Parse(Console.ReadLine());

            /*Criando um objeto para receber o resultado da busca,
             já que o objeto  retornado será do tipo Employee*/
            Employee emp = list.Find(x => x.Id == searchId);

            if( emp != null) {
                Console.Write("What is the increase percentage?");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
