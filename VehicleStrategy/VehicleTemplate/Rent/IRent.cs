using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public interface IRent
    {
        double Time { get; set; } //min.

        double CountThePrice(IVehile Vehile);
        double Discount(IVehile Vehile);
        bool AdditionalServices(IVehile Vehile);
    }
}
