using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Mouse : Animal, IMammal
    {
        private const double MouseWeightMultiplier = 0.1;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override double FoodMultipliyer => MouseWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferedFoods => 
            new HashSet<Type> { typeof(Vegetable),typeof(Fruit)};

        public override string ProduceSound() => "Squeak";
        public override string ToString() => $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";



    }
}
