﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentBicycleUntilDay : RentBicycle
    {
        public RentBicycleUntilDay(Bicycle bicycle, double time = 0) : base(bicycle, time)
        {
        }


        public override bool AdditionalServices()
        {
            return false;
        }

        public override double CountThePrice()
        {
            return Bicycle.TimeTarif * Time;
        }

        public override double Discount()
        {
            if (Bicycle.Type == "Electricity" || Bicycle.Type == "Eco") return CountThePrice() * 0.1;
            else return 0;
        }
    }
}
