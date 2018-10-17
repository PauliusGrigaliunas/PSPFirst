using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    public class RideABicycle
    {
        private IRent _rent;
        private Bicycle _bicycle;


        public RideABicycle(Bicycle bicycle, IRent rent, double time = 0)
        {
            _bicycle = bicycle;
            _rent = rent;
            _rent.Time = time;
        }
        public void MakeADeal()
        {
            Console.WriteLine("Name - " + _bicycle.Name);
            Console.WriteLine("Price - " + Math.Round(_rent.CountThePrice(_bicycle), 2) + @"€");
            Console.WriteLine("Discount - " + Math.Round(_rent.Discount(_bicycle), 2) + @"€");
            Console.WriteLine("Real price - " + Math.Round(_rent.CountThePrice(_bicycle)-_rent.Discount(_bicycle), 2) + @"€");
            Console.WriteLine("AdditionalService - " + _rent.AdditionalServices(_bicycle).ToString());
            Console.WriteLine();


        }
    }
}
