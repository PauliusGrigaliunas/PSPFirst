using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy.Discount
{
     interface IDiscount
    {
        double MakeDiscount(IRent rent);
    }
}
