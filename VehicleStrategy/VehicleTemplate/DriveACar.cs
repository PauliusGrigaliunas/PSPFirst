using System;
using System.Collections.Generic;
using System.Text;
using VehicleStrategy.Ecology;

namespace VehicleStrategy
{
    class DriveACar
    {
        public double Distance { get; set; }

        private IRent _rent;
        private IMode _mode;
        private Car _car;

        public DriveACar(Car car, IRent rent, IMode mode, double time = 0, double distance = 0)
        {
            _car = car;
            _rent = rent;
            _rent.Time = time;
            _mode = mode;

        }
        public void ReturnVehile()
        {
            
            Console.WriteLine("Name - " + _car.Name);
            Console.WriteLine("Price - " + Math.Round(_rent.CountThePrice(_car), 2) + @"€");
            Console.WriteLine("Discount - " + Math.Round( _rent.Discount(_car), 2) + @"€");
            Console.WriteLine("Real price - " + Math.Round(_rent.CountThePrice(_car)-_rent.Discount(_car), 2) + @"€");
            Console.WriteLine("AdditionalService - " + _rent.AdditionalServices(_car).ToString());
            Console.WriteLine("How much polution is made to nature - " + _mode.PollutionAmount(_car, Distance));
            
            Console.WriteLine();
        }

    }
}
