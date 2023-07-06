using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        
        private double addedFuel;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double addedFuel)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;   
            this.addedFuel = addedFuel;



        }
        public double TankCapacity { get; private set; }

        public double FuelQuantity { get => fuelQuantity; 
            private set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
                   
            }
            
               
            } 
       


        public double FuelConsumption { get; private set; }

       

        public virtual void Refuel(double litters)
        {
            if (FuelQuantity + litters  > TankCapacity)
            {
                throw new ArgumentException ($"Cannot fit {litters} fuel in the tank");
            }
            else if (litters <= 0 )
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            FuelQuantity += litters;
        }

        public string Drive(double distance, bool IsAddedFuel)
        {

            double consumption = IsAddedFuel
                ? FuelConsumption + addedFuel 
                : FuelConsumption;
            if (distance * consumption > FuelQuantity)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");

            }
            

            FuelQuantity -= distance * consumption;
            return $"{GetType().Name} travelled {distance} km";
        }

    }
}
