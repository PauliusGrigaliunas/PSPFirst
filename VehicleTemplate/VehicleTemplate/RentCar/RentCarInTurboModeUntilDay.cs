using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentCarInTurboModeUntilDay : RentCar
    {
        public RentCarInTurboModeUntilDay(Car car,  double time = 0, double distance = 0) : base(car, time, distance)
        {
        }

        public override bool AdditionalServices()
        {
            return false;
        }

        public override double CountThePrice()
        {
            return Car.TimeTarif * Time;
        }

        public override double Discount()
        {
            if (Car.Type == "Electricity" || Car.Type == "Eco") return CountThePrice() * 0.1;
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
