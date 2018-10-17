using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public abstract class RentVehile
    {
        public IVehile Vehile { set; get; }
        public double Time { get; set; } //min.

        public abstract double CountThePrice();
        public abstract double Discount();
        public abstract bool AdditionalServices();


        public virtual void MakeADeal()
        {
            Console.WriteLine();
            Console.WriteLine("Name - " + Vehile.Name);
            Console.WriteLine("Price - " + Math.Round(CountThePrice(), 2) + @"€");
            Console.WriteLine("Discount - " + Math.Round(Discount(), 2) + @"€");
            Console.WriteLine("Real price - " + Math.Round(CountThePrice() - Discount(), 2) + @"€");
            Console.WriteLine("AdditionalService - " + AdditionalServices().ToString());

        }
    }
}
