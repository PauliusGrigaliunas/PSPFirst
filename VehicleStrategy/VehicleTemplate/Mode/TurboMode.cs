using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public class TurboMode : IMode
    {
        public double PollutionAmount(Car car, double distance)
        {
            if (car.Type == "Electricity" || car.Type == "Eco") return 0;
            else return distance * car.Engine * 0.1;
        }
    }
}
