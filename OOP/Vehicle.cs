using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

 public interface IDrivable
    {
        string Drive(double distance);
    }

  public abstract class AbstractVehicle : IDrivable
    {
        public virtual string Drive(double distance)
        {
            return $"{this.GetType().Name} wants to drive for {distance}";
        }

        public abstract string Turn();
    }

   public class Vehicle : AbstractVehicle
    {
        protected int someValue;
        public string Brand { get; set; }
        public string RegNo { get; set; }

        public Vehicle(string brand, string regno = "Abc123")
        {
            Brand = brand;
            RegNo = regno;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }
    }

    public class FuelVehicle : Vehicle
    {
        private double fuelLevel;

        public double FuelLevel 
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, Fuelcapacity);
            }
        }


        public double Fuelcapacity { get; }
        public FuelVehicle(string brand, string regNo, double fuelcapacity) : base(brand, regNo)
        {
            Fuelcapacity = fuelcapacity;
        }

    }

    public class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double MaxDistance // => FuelLevel / fuelConsumption;
        {
            get
            {
                return FuelLevel / fuelConsumption;
            }
        }

        public FuelCar() :  this("DefaultBrandName", 100, "XXX555") { }

        public FuelCar(string brand, double fuelcapacity, string regno) : base(brand, regno, fuelcapacity){}

        public override string Drive(double distance)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Drive(distance));

            if(distance < 0)
            {
                distance = 0;
                result.AppendLine("Negative distance is assumed to be 0");
            }

            //FuelLevel = FuelLevel - (distance * fuelConsumption);
            FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"RegNo: {RegNo} drove {distance} km");

            return result.ToString();
        }

        public string Sound()  => "Tut tut Greta!";
        //{
        //    return "Tut tut";
        //}
    }


    public class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }
        public override string Drive(double distance)
        {
            return "Bicycle starts pedaling";
        }
    }
}
