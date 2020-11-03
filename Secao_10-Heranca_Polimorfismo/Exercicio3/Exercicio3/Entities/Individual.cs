using System;
using System.Security.Principal;

namespace Exercicio3.Entities
{
    class Individual : TaxPlayer
    {
        public decimal HealthExpenditures { get; set; }

        public Individual(string name, decimal anualIncome, decimal healthExpenditures):base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override decimal Tax()
        {
            decimal Tax = AnualIncome < 20000 ? 15 : 25;
            decimal discount = HealthExpenditures > 0 ? HealthExpenditures / 2 : 0;

            return (AnualIncome*(Tax/100)-discount);
        }
    }
}
