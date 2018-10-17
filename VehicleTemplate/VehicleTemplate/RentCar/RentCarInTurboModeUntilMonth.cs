using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTemplate
{
    public class RentCarInTurboModeUntilMonth : RentCar
    {
        public RentCarInTurboModeUntilMonth(Car car, double time = 0, double distance = 0) : base(car,  time, distance)
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
        protected override double PollutionAmount()
        {
            if (Car.Type == "Electricity" || Car.Type == "Eco") return 0;
            else return Distance * Car.Engine * 0.02;
        }
    }
}
