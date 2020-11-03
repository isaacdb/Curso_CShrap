using ExercicioEnum1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnum1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public Departament Department { get; set; }
        public float BaseSalary { get; private set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, float baseSalary)
        {
            Name = name;
            this.level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public float Income(int month, int year)
        {
            float Sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Month == month && contract.Date.Year == year)
                Sum += contract.TotalValue();
            }
            return Sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.Append(Name);
            sb.Append(", Department: ");
            sb.Append(Department);
            return sb.ToString();

        }

    }
}
