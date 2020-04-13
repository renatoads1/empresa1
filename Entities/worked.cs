using System;
using System.Collections.Generic;
using System.Text;
using empresa1.Entities.Enum;

namespace empresa1.Entities
{
    class worked
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //associação entre clases
        public Department Department { get; set; }
        //este é uma lista porque cada objeto pode ter vários contratos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public worked()
        {
        }

        public worked(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) 
        {//adiciona um contrato a lista de contratos
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {//remove um contrato da lista de contratos do objeto
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract cont in Contracts) {
                if (cont.Data.Year == year && cont.Data.Month == month) {
                    sum += cont.TotalValue();
                }

            }
            return sum;
        }

    }
}
