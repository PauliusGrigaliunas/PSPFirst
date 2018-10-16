using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    class Bicycle : IVehile
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double TimeTarif { get; set; }
        public int NumberOfSeats { get; set; }

        public Bicycle(string name, string type, double timeTarif, int numberOfSeats) {
            Name = name;
            Type = type;
            TimeTarif  = timeTarif;
            NumberOfSeats = numberOfSeats;
        }
    }
}
