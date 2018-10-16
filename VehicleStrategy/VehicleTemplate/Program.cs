using System;

namespace VehicleStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var AudiA6 = new Car("Audi A6", "Diesel", 2.0, 5, 0.2);
            var BMV535 = new Car("BMW535", "Diesel", 3.0, 5, 0.3);
            var Tesla = new Car("Tesla", "Electricity", 1.0, 2, 0.18);
            var BMX = new Bicycle("BMX", "ECO", 1, 0.08);


            var rentFirstCar = new DriveACar(AudiA6, new RentUntilDay(), new SimpleMode(), 10, 5);
            rentFirstCar.MakeADeal();

            var rentSecondCar = new DriveACar(BMV535, new RentUntilMonth(), new TurboMode(), 8*1440, 123);
            rentSecondCar.MakeADeal();

            var rentThirdCar = new DriveACar(Tesla, new RentUntilMonth(), new SimpleMode(), 30*1440, 74);
            rentThirdCar.MakeADeal();

            var rentFirstBicycle = new RideABicycle(BMX, new RentUntilDay(), 30);
            rentFirstBicycle.MakeADeal();
        }
    }
}
