using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public interface IMode
    {
        double PollutionAmount(Car car, double distance);
    }
}
