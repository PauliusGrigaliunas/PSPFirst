using System;
using VehicleStrategy.Discount;

namespace VehicleStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var AudiA6 = new Car("Audi A6", "Disel", "2.0tdi", 5, 0.2, 0.1);
            var BMV535 = new Car("BMW535", "Disel", "3.0tdi", 5, 0.3, 0.2);
            var Tesla = new Car("Tesla", "Electricity", "Electricity", 2, 0.18, 0.05);
            var BMX = new Bicycle("BMX", "ECO", 1, 0.08);


            var rentFirstCar = new DriveACar(new RentUntilDay(AudiA6), new DiscountForChristmas(), 10);
            rentFirstCar.UseVehile();

            var rentSecondCar = new DriveACar(new RentUntilMonth(BMV535), null, 8);
            rentSecondCar.UseVehile();

            var rentThirdCar = new DriveACar(new RentUntilMonth(Tesla), null, 8);
            rentThirdCar.UseVehile();

            var rentFirstBicycle = new DriveACar(new RentUntilDay(BMX), null, 30);
            rentFirstBicycle.UseVehile();
        }
    }
}
