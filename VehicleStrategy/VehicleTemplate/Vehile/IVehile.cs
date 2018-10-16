using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public interface IVehile
    {
        string Name { set; get; }
        string Type { set; get; }
        double TimeTarif { set; get; }
        double DistanceTarif { set; get; }
        int NumberOfSeats { set; get; }

    }
}
