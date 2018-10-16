using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy.Ecology
{
    public class SimpleMode : IMode
    {
        public double PollutionAmount(Car car, double distance)
        {
            if (car.Type == "Diesel") return distance * car.Engine * 0.02;
            return 0;
        }
    }
}
