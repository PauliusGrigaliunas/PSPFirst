using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    abstract class AbstractCar
    {
        protected abstract String Special(Car car);
        public double RentPrice(Car car, double time, double distance)
        {
            return car.TimeTarif * time + car.DistanceTarif * distance;
        }
    }
}
