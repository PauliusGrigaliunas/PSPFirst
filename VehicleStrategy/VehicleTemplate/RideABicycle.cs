using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategy
{
    class RideABicycle
    {
        private IRent _rent;


        public RideABicycle(IRent rent, double time = 0, double distance = 0)
        {
            _rent = rent;
            _rent.Time = time;
            _rent.Distance = distance;
        }
        public void UseVehile()
        {
            Console.WriteLine("Name - " + _rent.Vehile.Name);
            Console.WriteLine("Cost - " + _rent.CountThePrice() + @"€");
            Console.WriteLine("How much polution is made to nature - " + _rent.PollutionToNature());
            Console.WriteLine("AdditionalService - " + _rent.AdditionalServices().ToString());
            Console.WriteLine();


        }
    }
}
