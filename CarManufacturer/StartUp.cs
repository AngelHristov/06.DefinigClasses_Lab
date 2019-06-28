namespace CarManufacturer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(2, 2.4),
                new Tire(3, 2.3),
                new Tire(4, 2.2),
            };

            var engine = new Engine(200, 1987.3);

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Car fourthCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);

            fourthCar.WhoAmI();
        }
    }
}
