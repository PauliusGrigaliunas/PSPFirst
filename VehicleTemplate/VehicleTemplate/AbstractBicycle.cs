using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    abstract class AbstractBicycle
    {
        protected abstract String Special(Bicycle bicycle);
        public double RentPrice(Bicycle bicycle, double time)
        {
            return bicycle.TimeTarif * time;
        }
    }
}
