using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public interface IMode
    {
        double PollutionAmount(Car car, double distance);
    }
}
