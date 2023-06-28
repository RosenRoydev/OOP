using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private const double baseCalorie = 2;
        private readonly Dictionary<string, double> toppingCalories;

        private string typeOfTopping;
        private double weight;

        public Topping(string typeOfTopping, double weight)
        {
            toppingCalories = new Dictionary<string, double> { {"meat", 1.2 }, { "veggies",0.8 },
            { "cheese",1.1} ,{"sauce",0.9 } };
            TypeOfTopping = typeOfTopping;
            Weight = weight;
            



        }
        public string TypeOfTopping
        {
            get => typeOfTopping;

            private set
            {
                if (!toppingCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                typeOfTopping = value;
            }

        }


        public double Weight
        {
            get => weight;

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException
                        ($"{TypeOfTopping} weight should be in the range [1..50].");
                }
                weight = value;
            }

        }

        public double CaloriesPerGram
        {
            get
            {
                double typeOfToppingModifield = toppingCalories[TypeOfTopping.ToLower()] ;
                return typeOfToppingModifield * Weight * baseCalorie ;
            }

        }
    }
}
