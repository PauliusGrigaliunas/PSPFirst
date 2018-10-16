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

        public IVehile Vehile { get; set; }

        public RentUntilMonth(IVehile vehile)
        {
            Vehile = vehile;
        }

        public bool AdditionalServices()
        {
            if (Vehile.NumberOfSeats >= 4) return true;
            else return false;
        }

        public double PollutionToNature()
        {
            if (Vehile.Type == "Electricity" || Vehile.Type == "Eco") return 0;
            else return Distance * 0.1;
        }

        public double CountThePrice()
        {
            return Vehile.DistanceTarif * Distance + Vehile.TimeTarif * Time * 14.4  ;
        }

    }
}
