using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentCarInSimpleModeUnilMonth : RentCar
    {
        public RentCarInSimpleModeUnilMonth(Car car, double time = 0, double distance = 0) : base(car,  time, distance)
        {
        }

        protected override bool AdditionalServices()
        {
            if (Car.NumberOfSeats >= 4) return true;
            else return false;
        }

        protected override double CountThePrice()
        {
            return Car.TimeTarif * Time * 0.02;
        }

        protected override double Discount()
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
