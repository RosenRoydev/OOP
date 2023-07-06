using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Factory.Interface;
using VehiclesExtension.Models;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Factory
{
    public class CreateVehicle : ICreateVehicle
    {
       

        

       

        public IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            switch (type)
            {
                case "Bus":
                    return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                case "Car":
                    return new Car(fuelQuantity, fuelConsumption, tankCapacity);
                default:
                    throw new ArgumentException("Invalid vehicle type");

            }
        }
    }
}
