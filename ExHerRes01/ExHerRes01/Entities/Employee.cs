using System;
using System.Collections.Generic;
using System.Text;

namespace ExHerRes01.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        /*O método Payment recebeu o sufixo virtual para que possa ser sobrescrito na subclasse*/
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
