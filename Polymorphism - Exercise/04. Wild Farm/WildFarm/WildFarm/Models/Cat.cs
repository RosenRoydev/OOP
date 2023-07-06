using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Cat : Feline, IMammal
    {
        private const double CatWeightMultiplier = 0.3;
        public Cat(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion, breed)
        {
        }

        public override double FoodMultipliyer => CatWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferedFoods => 
            new HashSet<Type> { typeof(Meat),typeof(Vegetable)};

        public override string ProduceSound() => "Meow";


    }
}
