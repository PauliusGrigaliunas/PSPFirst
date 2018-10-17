﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentCarInTurboModeUntilMonth : RentCar
    {
        public RentCarInTurboModeUntilMonth(Car car, double time = 0, double distance = 0) : base(car,  time, distance)
        {
        }

        public override bool AdditionalServices()
        {
            if (Car.NumberOfSeats >= 4) return true;
            else return false;
        }

        public override double CountThePrice()
        {
            return Car.TimeTarif * Time * 0.02;
        }

        public override double Discount()
        {
            if (Car.Type == "Electricity" || Car.Type == "Eco") return CountThePrice() * 0.18;
            else return 0;
        }
        public double PollutionAmount(Car car, double distance)
        {
            if (car.Type == "Electricity" || car.Type == "Eco") return 0;
            else return distance * car.Engine * 0.02;
        }
        public override void MakeADeal()
        {
            base.MakeADeal();
            Console.WriteLine("How much polution is made to nature - " + PollutionAmount(Car, Distance));
        }
    }
}
