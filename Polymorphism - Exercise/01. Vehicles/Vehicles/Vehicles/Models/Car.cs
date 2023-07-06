using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private static double carAddedFuel = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption, carAddedFuel)
        {
        }

        public override string ToString() => $"Car: {FuelQuantity:f2}";





    }
}
