using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentBicycleUntilMonth : RentBicycle
    {

        public RentBicycleUntilMonth(Bicycle bicycle, double time = 0) : base(bicycle, time)
        {
        }

        protected override bool AdditionalServices()
        {
            if (Bicycle.NumberOfSeats >= 4) return true;
            else return false;
        }

        protected override double CountThePrice()
        {
            return Bicycle.TimeTarif * Time * 0.02;
        }

        protected override double Discount()
        {
            if (Bicycle.Type == "Electricity" || Bicycle.Type == "Eco") return CountThePrice() * 0.18;
            else return 0;
        }
    }
}
