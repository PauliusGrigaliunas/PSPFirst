using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public abstract class RentBicycle
    {
        public Bicycle Bicycle { set; get; }
        public double Time { get; set; } //min.

        public RentBicycle(Bicycle bicycle, double time = 0)
        {
            Bicycle = bicycle;
            Time = time;
        }

        public abstract double CountThePrice();
        public abstract double Discount();
        public abstract bool AdditionalServices();


        public virtual void MakeADeal()
        {
            Console.WriteLine();
            Console.WriteLine("Name - " + Bicycle.Name);
            Console.WriteLine("Price - " + Math.Round(CountThePrice(), 2) + @"€");
            Console.WriteLine("Discount - " + Math.Round(Discount(), 2) + @"€");
            Console.WriteLine("Real price - " + Math.Round(CountThePrice() - Discount(), 2) + @"€");
            Console.WriteLine("AdditionalService - " + AdditionalServices().ToString());

        }
    }
}
