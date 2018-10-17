using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
     public abstract class RentCar
    {
        public Car Car { set; get; }
        public double Time { get; set; } //min.      
        public double Distance { get; set; }

        public RentCar(Car car, double time = 0, double distance = 0)
        {
            Car = car;
            Time = time;
            Distance = distance;
        }
        protected abstract double CountThePrice();
        protected abstract double Discount();
        protected abstract bool AdditionalServices();
        protected abstract double PollutionAmount(Car car, double distance);

        public virtual void MakeADeal()
        {
            Console.WriteLine();
            Console.WriteLine("Name - " + Car.Name);
            Console.WriteLine("Price - " + Math.Round(CountThePrice(), 2) + @"€");
            Console.WriteLine("Discount - " + Math.Round(Discount(), 2) + @"€");
            Console.WriteLine("Real price - " + Math.Round(CountThePrice() - Discount(), 2) + @"€");
            Console.WriteLine("AdditionalService - " + AdditionalServices().ToString());
            
        }
    }
}
