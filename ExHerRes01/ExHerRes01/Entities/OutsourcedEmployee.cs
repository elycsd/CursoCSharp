using System;
using System.Collections.Generic;
using System.Text;

namespace ExHerRes01.Entities
{
    /*OutsourcedEmployee : Employee = OutsourcedEmployee herda de Employee, é uma subclasse de Employee*/
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        /*No  construtor com quatro argumentos : base(name, hours, valuePerHour) significa
         * que os argumentos name, hours, valuePerHour são aproveitados da classe base,
         ou seja, da classe Employee*/
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        /*override double Payment() = sobrescrevendo o método Payment(), para que o mesmo se comporte
         de forma diferente na subclasse, esta é uma característica do polimorfismo.*/
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }
    }
}
