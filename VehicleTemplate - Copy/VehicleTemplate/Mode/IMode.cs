using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    interface IMode
    {
        double PollutionAmount(Car car, double distance);
    }
}
