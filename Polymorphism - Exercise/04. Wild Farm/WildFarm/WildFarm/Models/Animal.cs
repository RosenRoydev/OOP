using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight) 
        { 
           Name  = name;
            Weight = weight;
          
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public abstract double FoodMultipliyer { get; }

        protected abstract IReadOnlyCollection<Type> PreferedFoods { get; } 
        public void Eat(IFood food)
        {
            if(!PreferedFoods.Any(pf => food.GetType().Name == pf.Name))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            Weight += food.Quantity * FoodMultipliyer;
            FoodEaten += food.Quantity;
        }
        public abstract string ProduceSound();

        



    }
}
