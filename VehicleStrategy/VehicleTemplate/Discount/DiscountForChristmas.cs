using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy.Discount
{
    class DiscountForChristmas : IDiscount
    {

        public double MakeDiscount(IRent rent)
        {
            return rent.CountThePrice() * 0.1;
        }
    }
}
