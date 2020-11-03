using System.Text;

namespace Exercicio2.Entities
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product()
        {
        }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $" + Price;
        }
    }
}
