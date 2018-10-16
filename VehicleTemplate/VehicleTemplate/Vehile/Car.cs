using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate 
{
    class Car : IVehile
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double TimeTarif { get; set; }
        public double DistanceTarif { get; set; }
        public string Engine { get; set; }
        public int NumberOfSeats { get; set; }

        public Car(string name, string type, double timeTarif, double distanceTarif, string engine, int numberOfSeats)
        {

            Name = name;
            Type = type;
            TimeTarif = timeTarif;
            DistanceTarif = distanceTarif;
            Engine = engine;
            NumberOfSeats = numberOfSeats;
        }
    }
}
