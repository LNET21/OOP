using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            FuelVehicle fuelVehicle = new FuelVehicle("Volvo", "aaa333");
            Vehicle vehicle = new Vehicle("Saab");

            List<AbstractVehicle> vehicles = new List<AbstractVehicle>()
            {
                fuelVehicle, vehicle, new Vehicle("Mazda")
            };
            vehicles.Add(new Vehicle("Audi"));
            vehicles.Add(new Bicycle());

            foreach (AbstractVehicle v in vehicles)
            {
                Console.WriteLine(v.Drive(23));
            }

            //vehicles.ForEach(v => v.Drive(23));
                


          
            
            
        }
    }
}
