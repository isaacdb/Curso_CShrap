using Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicio.Services
{
    class ProcessContract
    {
      //  public Contract Contract { get; set; }
        public IServiceOnline ServiceOnline { get; set; }

        public ProcessContract(IServiceOnline serviceOnline)
        {
           // Contract = contract;
            ServiceOnline = serviceOnline;
        }
        public void GenerateParcels(Contract contract)
        {
            decimal initValue = contract.Value / contract.QuantityParcels;
            decimal tax = ServiceOnline.Tax();
            decimal interest = ServiceOnline.Interest();

            for (int i = 1; i <= contract.QuantityParcels; i++)
            {
                decimal valuePerParcel = initValue + initValue * interest * i;
                valuePerParcel += valuePerParcel * tax;

                DateTime parcelDate = contract.Date.AddMonths(1 * i);
                Parcel parcel = new Parcel(contract.ContractCode, parcelDate, valuePerParcel);

                contract.Parcels.Add(parcel);
            }
        }


    }
}
