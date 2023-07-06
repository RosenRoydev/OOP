using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double addedFuel;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double addedFuel) 
        { 
          FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.addedFuel = addedFuel;
            
        
        
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public virtual void Refuel(double  litters)
        {
            FuelQuantity += litters;
        }

        public string Drive(double distance)
        {
            double consumption = FuelConsumption + addedFuel;
            if (distance * consumption <= FuelQuantity)
            {
                FuelQuantity -= distance * consumption;
                return $"{GetType().Name} travelled {distance} km";
                
            }
            return $"{GetType().Name} needs refueling";
        }
        
    }
}
