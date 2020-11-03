using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Enum.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
