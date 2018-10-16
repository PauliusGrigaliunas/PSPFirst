using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentCarInSimpleModeUnilMonth : RentCar
    {
        public RentCarInSimpleModeUnilMonth(Car car, double time = 0, double distance = 0) : base(car,  time, distance)
        {
            Mode = new SimpleMode();
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
    }
}
