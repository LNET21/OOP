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
            return $"{this.GetType().Name} drove for {distance}";
        }

        public abstract string Turn();
    }

   public class Vehicle : AbstractVehicle
    {
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


        //public override  string Drive(double distance)
        //{
        //    return base.Drive(distance);
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
