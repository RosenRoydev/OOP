﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double addedFuel = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption,tankCapacity, addedFuel)
        {

        }
        public override string ToString() => $"Bus: {FuelQuantity:f2}";
    }
}
