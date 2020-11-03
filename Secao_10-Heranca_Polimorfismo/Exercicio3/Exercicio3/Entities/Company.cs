namespace Exercicio3.Entities
{
    class Company : TaxPlayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, decimal anualIncome, int numberOfEmployees):base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override decimal Tax()
        {
            decimal Tax = NumberOfEmployees > 10 ? 14 : 16;
            return (AnualIncome*(Tax/100));
        }
    }
}
