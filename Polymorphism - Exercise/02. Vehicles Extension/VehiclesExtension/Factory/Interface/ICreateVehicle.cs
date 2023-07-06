using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Factory.Interface
{
    public interface ICreateVehicle
    {
        IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity);
    }
}
