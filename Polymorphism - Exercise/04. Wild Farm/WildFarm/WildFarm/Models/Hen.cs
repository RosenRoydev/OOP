using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const double HenWeightMultiplier = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double FoodMultipliyer => HenWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferedFoods => 
            new HashSet<Type> {typeof(Seeds),typeof(Meat),typeof(Fruit),typeof(Vegetable) };

        public override string ProduceSound() => "Cluck";
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";


        }


    }
}
