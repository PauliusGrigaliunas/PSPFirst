using System;
using System.Collections.Generic;
using System.Text;
using VehicleStrategy.Discount;

namespace VehicleStrategy
{
    class DriveACar
    {
        private IRent _rent;
        private IDiscount _discount;

        public DriveACar(IRent rent, IDiscount discount, double time = 0, double distance = 0)
        {
            _discount = discount;
            _rent = rent;
            _rent.Time = time;
            _rent.Distance = distance;
        }
        public void UseVehile()
        {
            
            Console.WriteLine("Name - " + _rent.Vehile.Name);
            Console.WriteLine("Price - " + _rent.CountThePrice() + @"€");

            if (_discount != null) { 
            Console.WriteLine("Discount - " + _discount.MakeDiscount(_rent));
            Console.WriteLine("Price with Discount - " + (_rent.CountThePrice() - _discount.MakeDiscount(_rent)) + @"€");
            }

            Console.WriteLine("How much polution is made to nature - " + _rent.PollutionToNature());
            Console.WriteLine("AdditionalService - " + _rent.AdditionalServices().ToString());
            Console.WriteLine();
        }

    }
}
