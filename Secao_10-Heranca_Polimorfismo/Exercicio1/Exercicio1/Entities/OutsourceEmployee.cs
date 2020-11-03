using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class OutsourceEmployee : Employee
    {
        public float AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(float additionalCharge, string name, int hours, float valuePerHour):base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override float Payment()
        {
            return (float)(base.Payment() + 1.1 * AdditionalCharge);
        }
    }
}
