using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.Entities
{
    class ImportedProduct:Product
    {
        public float CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, float price, float customFee)
            :base(name,price)
        {
            CustomFee = customFee;
        }
        public float TotalPrice()
        {
            return Price + CustomFee;
        }
        public override string PriceTag()
        {
            return Name + " $" + TotalPrice() + "Customs fee: $" + CustomFee;
        }
    }
}
