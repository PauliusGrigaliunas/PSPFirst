using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    class RentUntilDay : IRent
    {
        public double Time { get; set; }
        public double Distance { get; set; }
        public bool VehileNeedFuels { get ; set; }

        public IVehile Vehile { get; set; }

        public RentUntilDay(IVehile vehile) {
            Vehile = vehile;
        }


        public double PollutionToNature()
        {
            if (Vehile.Type == "Electricity" || Vehile.Type == "Eco") return 0;
            else return Distance * 0.2;
        }

        public double CountThePrice()
        {
            return Vehile.TimeTarif * Time;
        }

        public bool AdditionalServices()
        {
            return false;
        }
    }
}
