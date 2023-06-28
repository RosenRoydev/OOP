using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> toppingsForPizza;

        public Pizza(string name, Dough dough) 
        {
           Name = name;
            Dough = dough;
            toppingsForPizza = new List<Topping>(); 

        }




        public string Name
        {
            get => name;

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }

        }

        public Dough Dough { get; private set; }

        public double TotalCalories
        {
            get
            {
                double totalCalories = Dough.Calories + toppingsForPizza.Sum( t => t.CaloriesPerGram);
                 return totalCalories;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppingsForPizza.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppingsForPizza.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories:f2} Calories.";
        }
    }
}
