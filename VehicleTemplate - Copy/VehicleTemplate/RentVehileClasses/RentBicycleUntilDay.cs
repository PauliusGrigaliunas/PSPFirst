using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    class RentBicycleUntilDay : RentVehile
    {
        public RentBicycleUntilDay(Bicycle bicycle, double time = 0) 
        {
            Vehile = bicycle;
            Time = time;
        }

        public override bool AdditionalServices()
        {
            return false;
        }


        public override double CountThePrice()
        {
            return Vehile.TimeTarif * Time;
        }

        public override double Discount()
        {
            if (Vehile.Type == "Electricity" || Vehile.Type == "Eco") return CountThePrice() * 0.1;
            else return 0;
        }

    }
}
