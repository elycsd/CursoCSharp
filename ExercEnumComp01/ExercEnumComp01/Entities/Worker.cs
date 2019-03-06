using System.Collections.Generic;
using ExercEnumComp01.Entities.Enums;

namespace ExercEnumComp01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        /*Composição de objetos: Existe uma associação entre Worker e Department, portanto,
          dentro da classe Worker deve ser declarada uma propriedade do tipo Department,
          com o nome Department.*/
        public Department Department { get; set; }
        /*Um trabalhador pode ter vários contratos. Dentro da classe Worker deve haver
         uma propriedade chamada Contracts, como podem ser vários contratos o tipo
         da propriedade deve ser List*/
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        /*No construtor com argumentos não se deve incluir as associações para muitos,
         porque não é usual se passar uma lista instanciada no construtor de objetos.
         A lista começa vazia, e depois os objetos vão sendo adicionados conforme a necessidade.
         Por via de regra, quando houver uma associação de um para muitos, ela não deve ser
         incluida no construtor.*/
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        /*Os métodos addContract e removeContract recebem como argumento um objeto
         do tipo HourContract e acesssam a lista de contratos para adicionar ou
         remover um contrato*/
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        /*O método Income retorna o ganho total de um trabalhador em um mês de um determinado
         ano. Independente de ter ou não um contrato no referido mês, o trabalhador recebe
         o salário base. Para cada contrato do dado mês, será chamado o método que calcula
         o valor do contrato e o valor será somado ao salario base.*/
        public double Income( int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
