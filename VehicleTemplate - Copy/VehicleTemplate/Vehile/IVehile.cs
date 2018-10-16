using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public interface IVehile
    {
        string Name { set; get; }
        string Type { set; get; }
        double TimeTarif { set; get; }
        int NumberOfSeats { set; get; }

    }
}
