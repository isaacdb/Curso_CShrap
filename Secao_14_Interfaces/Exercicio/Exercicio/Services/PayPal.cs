using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Services
{
    class PayPal : IServiceOnline
    {
        public decimal PaypalTax { get; set; } = 0.02M;
        public decimal PaypalInterest { get; set; } = 0.01M;


        public decimal Interest()
        {
            return PaypalInterest;
        }

        public decimal Tax()
        {
            return PaypalTax;
        }
    }
}
