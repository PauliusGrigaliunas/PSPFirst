using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public  class RentUntilDay : IRent
    {
        public double Time { get; set; }
        public double Distance { get; set; }

        public double Discount(IVehile vehile)
        {
            if (vehile.Type == "Electricity" || vehile.Type == "Eco") return CountThePrice(vehile)* 0.1;
            else return 0;
        }

        public double CountThePrice(IVehile vehile)
        {
            return vehile.TimeTarif * Time;
        }

        public bool AdditionalServices(IVehile vehile)
        {
            return false;
        }
    }
}
