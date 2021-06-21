using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

  public abstract class AbstractVehicle
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

        public FuelVehicle(string brand, string regNo) : base(brand, regNo)
        {
           
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
