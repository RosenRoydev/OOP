﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Dog : Animal,IMammal
    {
        private const double DogWeightMultiplier = 0.4;
        public Dog(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override double FoodMultipliyer => DogWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferedFoods =>
            new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound() => "Woof!";
        public override string ToString() => $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
