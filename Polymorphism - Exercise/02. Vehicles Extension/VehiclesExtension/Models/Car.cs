using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private static double carAddedFuel = 0.9;
        public Car(double fuelQuantity, double fuelConsumption,double tankCapacity) : 
            base(fuelQuantity, fuelConsumption,tankCapacity, carAddedFuel)
        {
        }

        public override string ToString() => $"Car: {FuelQuantity:f2}";

    }
}
