using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    internal class Truck : Vehicle
    {
        private const double TruckAddedFuel = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption, TruckAddedFuel)
        {
        }

        public override void Refuel(double litters)
        {
            base.Refuel(litters * 0.95);
        }
        public  string ToString() => $"Truck: {FuelQuantity:f2}";
    }
}
