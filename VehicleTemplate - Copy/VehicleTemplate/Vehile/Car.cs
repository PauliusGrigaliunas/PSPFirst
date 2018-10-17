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
        public double Engine { get; set; }
        public int NumberOfSeats { get; set; }

        public Car(string name, string type, double engine, int numberOfSeats, double timeTarif)
        {

            Name = name;
            Type = type;
            TimeTarif = timeTarif;
            Engine = engine;
            NumberOfSeats = numberOfSeats;
        }
    }
}
