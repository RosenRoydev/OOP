using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Feline : Animal, IMammal
    {
        protected Feline(string name, double weight,string livingregion, string breed) : base(name, weight)
        {
            LivingRegion = livingregion;
            Breed = breed;
        }
        public string LivingRegion { get; private set; }
        public string Breed { get; private set; }



        public override string ToString() => $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";


    }
}
