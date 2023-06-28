using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private const double CaloriesForGram = 2;
        private readonly Dictionary<string, double> flourTypeCalories;
        private readonly Dictionary<string, double> bakingTechniqueCalories;

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            flourTypeCalories = new Dictionary<string, double> { { "white", 1.5 }, { "wholegrain", 1.0 } };
            bakingTechniqueCalories = new Dictionary<string, double> { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };

            FlourType = flourType.ToLower();
            BakingTechnique = bakingTechnique.ToLower();
            Grams = grams;
            
            
        }

        public string FlourType
        {
            get { return flourType; }
            set 
            {
                if (!flourTypeCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }
        public double Grams
        {
            get { return grams; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }

        public double Calories
        {
            get 
            {
                

                double flourCaloriesPerGram = flourTypeCalories[flourType];
                double caloriesBakingTechniquePerGram = bakingTechniqueCalories[bakingTechnique];
                return (CaloriesForGram * Grams) * flourCaloriesPerGram * caloriesBakingTechniquePerGram;
            }
           
        }

    }
}
