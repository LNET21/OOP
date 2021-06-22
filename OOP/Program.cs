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
            vehicles.Add(car);

            foreach (var v in vehicles)
            {
                //FuelCar fuelCar = (FuelCar)v;
                //Console.WriteLine(fuelCar.Brand);
                //Console.WriteLine(fuelCar.Sound());

                FuelCar fuelCar1 = v as FuelCar;
                if(fuelCar1 != null)
                {
                    Console.WriteLine(fuelCar1.Sound());
                }

                Console.WriteLine(fuelCar1?.Sound());

                if(v is FuelCar)
                {
                    FuelCar temp = (FuelCar)v;
                    Console.WriteLine(temp.Sound());
                }

                if(v is FuelCar temp2)
                {
                    Console.WriteLine(temp2.Sound());
                }

                //int nr;
                //var ok = int.TryParse("222", out int nr);
                Console.WriteLine(v.Drive(23));
            }

            //vehicles.ForEach(v => v.Drive(23));
                


          
            
            
        }
    }
}
