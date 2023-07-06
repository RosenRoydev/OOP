using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Owl : Bird

    {
        private const double OwlWeightMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double FoodMultipliyer => OwlWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferedFoods => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound() => "Hoot Hoot";
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";


        }


    }
}
