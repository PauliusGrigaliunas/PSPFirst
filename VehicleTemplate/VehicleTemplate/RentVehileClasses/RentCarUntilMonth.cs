using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    class RentCarUntilMonth : RentVehile
    {
        public IMode Mode { get; set; }
        public double Distance { get; set; }

        public RentCarUntilMonth(Car car, IMode mode, double time = 0, double distance = 0)
        {
            Vehile = car;
            Mode = mode;
            Time = time;
            Distance = distance;
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

        public override void MakeADeal()
        {
            base.MakeADeal();
            Console.WriteLine("How much polution is made to nature - " + Mode.PollutionAmount((Car)Vehile, Distance));

        }

    }
}
