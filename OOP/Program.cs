using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            FuelCar car = new FuelCar();

            car.FuelLevel = 50;

            FuelVehicle fuelVehicle = new FuelVehicle("Volvo", "aaa333", 50);
            Vehicle vehicle = new Vehicle("Saab");

            List<IDrivable> vehicles = new List<IDrivable>()
            {
                fuelVehicle, vehicle, new Vehicle("Mazda")
            };
            vehicles.Add(new Vehicle("Audi"));
            vehicles.Add(new Bicycle());

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Drive(23));
            }

            //vehicles.ForEach(v => v.Drive(23));
                


          
            
            
        }
    }
}
