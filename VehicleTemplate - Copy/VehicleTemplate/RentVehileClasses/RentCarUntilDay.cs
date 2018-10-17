using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    class RentCarUntilDay : RentVehile
    {
        public IMode Mode { get; set; }
        public double Distance { get; set; }

        public RentCarUntilDay(Car car, IMode mode, double time = 0, double distance = 0)
        {
            Vehile = car;
            Mode = mode;
            Time = time;
            Distance = distance;
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
        public override void MakeADeal()
        {
            base.MakeADeal();
            Console.WriteLine("How much polution is made to nature - " + Mode.PollutionAmount((Car)Vehile, Distance));
        }
    }
}
