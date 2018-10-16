﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
     public abstract class RentCar
    {
        public Car Car { set; get; }
        public IMode Mode { get; set; }
        public double Time { get; set; } //min.      
        public double Distance { get; set; }

        public RentCar(Car car, double time = 0, double distance = 0)
        {
            Car = car;
            Time = time;
            Distance = distance;
        }
        public abstract double CountThePrice();
        public abstract double Discount();
        public abstract bool AdditionalServices();


        public virtual void MakeADeal()
        {
            Console.WriteLine();
            Console.WriteLine("Name - " + Car.Name);
            Console.WriteLine("Price - " + Math.Round(CountThePrice(), 2) + @"€");
            Console.WriteLine("Discount - " + Math.Round(Discount(), 2) + @"€");
            Console.WriteLine("Real price - " + Math.Round(CountThePrice() - Discount(), 2) + @"€");
            Console.WriteLine("AdditionalService - " + AdditionalServices().ToString());
            Console.WriteLine("How much polution is made to nature - " + Mode.PollutionAmount(Car, Distance));
            
        }
    }
}