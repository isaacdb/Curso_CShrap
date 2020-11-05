using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
