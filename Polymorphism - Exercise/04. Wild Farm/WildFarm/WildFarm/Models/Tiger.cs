using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Tiger : Feline, IMammal
    {
        private const double TigerWeightmultiplier = 1.0;
        public Tiger(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion, breed)
        {
        }

        public override double FoodMultipliyer => TigerWeightmultiplier;

        protected override IReadOnlyCollection<Type> PreferedFoods => new HashSet<Type> { typeof(Meat)};

        public override string ProduceSound() => "ROAR!!!";

    }
}
