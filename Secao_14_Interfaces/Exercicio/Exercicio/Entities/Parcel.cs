using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio.Entities
{
    class Parcel
    {
        public int ContractCode { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }

        public Parcel(int contractCode, DateTime date, decimal value)
        {
            ContractCode = contractCode;
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return "Code: " + ContractCode + " - " + Date.ToString("dd/MM/yyyy") + " - " + Value.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
