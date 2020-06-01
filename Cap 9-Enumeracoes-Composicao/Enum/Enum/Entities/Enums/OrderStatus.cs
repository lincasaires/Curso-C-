using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_.Entities.Enums
{
    enum OrderStatus : int //tipo base int
    {
        PendingPayment = 0, //valor inteiro padrão = 0
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
