using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    class RentBicycleUntilMounth : RentVehile
    {
        public RentBicycleUntilMounth(Bicycle bicycle, double time = 0)
        {
            Vehile = bicycle;
            Time = time;
        }
        public override bool AdditionalServices()
        {
            if (Vehile.NumberOfSeats >= 4) return true;
            else return false;
        }

        public override double CountThePrice()
        {
            return Vehile.TimeTarif * Time * 0.02;
        }

        public override double Discount()
        {
            if (Vehile.Type == "Electricity" || Vehile.Type == "Eco") return CountThePrice() * 0.18;
            else return 0;
        }
    }
}
