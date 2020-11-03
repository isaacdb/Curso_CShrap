using System;

namespace Exercicio3.Entities
{
    abstract class TaxPlayer
    {
        public string Name { get; set; }
        public decimal AnualIncome { get; set; }

        public TaxPlayer(string name, decimal anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract decimal Tax();

        public override string ToString()
        {
            return Name + ": $" + Tax();
        }
    }
}
