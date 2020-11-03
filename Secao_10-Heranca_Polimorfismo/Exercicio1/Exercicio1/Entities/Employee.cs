namespace Exercicio1.Entities
{
    class Employee
    {
        public string Name { get; set; }

        public int Hours { get; set; }
        public float ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, float valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual float Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
