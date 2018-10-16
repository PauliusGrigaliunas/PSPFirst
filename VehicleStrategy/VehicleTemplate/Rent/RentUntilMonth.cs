using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    class RentUntilMonth : IRent
    {
        public double Time { get; set; }
        public double Distance { get; set; }
        public bool VehileNeedFuels { get; set; }


        public bool AdditionalServices(IVehile vehile)
        {
            if (vehile.NumberOfSeats >= 4) return true;
            else return false;
        }

        public double Discount(IVehile vehile)
        {
            if (vehile.Type == "Electricity" || vehile.Type == "Eco") return CountThePrice(vehile) * 0.18;
            else return 0;
        }

        public double CountThePrice(IVehile vehile)
        {
            return  vehile.TimeTarif * Time * 0.02 ;
        }

    }
}
