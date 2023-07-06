﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    internal class FoodFactoy : IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            switch (type)
            {
                case "Fruit":
                    return new Fruit(quantity);
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}
