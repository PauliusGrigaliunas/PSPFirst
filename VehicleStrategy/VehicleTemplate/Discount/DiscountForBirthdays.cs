using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy.Discount
{
    class DiscountForBirthdays : IDiscount
    {
        public double MakeDiscount(IRent rent)
        {
            return rent.CountThePrice() * 0.2;
        }
    }
}
