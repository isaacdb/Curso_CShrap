using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    class Contract
    {
        public int ContractCode { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int QuantityParcels { get; set; }
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();

        public Contract(int contractCode, DateTime date, decimal value, int quantityParcels)
        {
            ContractCode = contractCode;
            Date = date;
            Value = value;
            QuantityParcels = quantityParcels;
        }
    }
}
