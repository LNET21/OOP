using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrivable volvo = new FuelCar();
            Vehicle volvo2 = new FuelCar();
            AbstractVehicle volvo3 = new FuelCar();

            

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
                Console.WriteLine(v.Drive(45));
                //Unsafe cast, Exception om inte casten lyckas
                //FuelCar fuelCar = (FuelCar)v;
                //Console.WriteLine(fuelCar.Brand);
                //Console.WriteLine(fuelCar.Sound());

                //Null om inte casten lyckas
                FuelCar fuelCar1 = v as FuelCar;
                if(fuelCar1 != null)
                {
                    Console.WriteLine(fuelCar1.Sound());
                }

                //?. Nullcheck
                Console.WriteLine(fuelCar1?.Sound());

                //Är instansen v en FuelCar?
                if (v is FuelCar)
                {
                    //Unsafe cast Exception om den inte fungerar
                    FuelCar temp = (FuelCar)v;
                    Console.WriteLine(temp.Sound());
                }

                //Är instansen v en FuelCar?
                //Om ja gör även en cast och tilldela resultatet tiil varibeln temp2
                if (v is FuelCar temp2)
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
