using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public interface IRent
    {
        IVehile Vehile { get; set; }
        double Time { get; set; } //min.
        double Distance { get; set; }
        bool VehileNeedFuels { get; set; }


        double CountThePrice();
        double PollutionToNature();
        bool AdditionalServices();
    }
}
