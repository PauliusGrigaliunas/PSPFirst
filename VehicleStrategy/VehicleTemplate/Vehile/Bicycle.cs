using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public class Bicycle : IVehile
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double TimeTarif { get; set; }
        public double DistanceTarif { get; set; }
        public int NumberOfSeats { get; set; }

        public Bicycle(string name, string type, int numberOfSeats, double timeTarif, double distanceTarif = 0 ) {
            Name = name;
            Type = type;
            TimeTarif  = timeTarif;
            DistanceTarif = distanceTarif;
            NumberOfSeats = numberOfSeats;
        }
    }
}
