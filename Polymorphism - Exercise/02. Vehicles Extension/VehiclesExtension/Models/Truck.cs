using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double TruckAddedFuel = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption,tankCapacity, TruckAddedFuel)
        {
        }

        public override void Refuel(double litters)
        {
            if (litters + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litters} fuel in the tank");
            }

            base.Refuel(litters * 0.95);
        }
        public override string ToString() => $"Truck: {FuelQuantity:f2}";
    }
}
