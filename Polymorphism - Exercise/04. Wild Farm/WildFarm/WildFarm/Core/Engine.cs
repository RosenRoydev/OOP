using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interface;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IAnimalFactory createAnimal;
        private readonly IFoodFactory createFood;

        public Engine (IReader reader, IWriter writer, IAnimalFactory createAnimal, 
            IFoodFactory createFood)
        {
            this.reader = reader;
            this.writer = writer;
            this.createAnimal = createAnimal;
            this.createFood = createFood;
        }

        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal> ();
            string input;
            while ((input = reader.ReadLine()) != "End")
            {
                
                try
                {
                    IAnimal animal = Create(input);
                    animals.Add(animal);
                    IFood food = CreateFood();
                    writer.Writeline(animal.ProduceSound());
                    animal.Eat(food);
                    
                }
                catch (ArgumentException ex)
                {

                    writer.Writeline(ex.Message);
                }
                

            }
            foreach (IAnimal animal in animals)
            {
                writer.Writeline(animal.ToString());
            }

        }

        private IAnimal Create (string input)
        
        {
            string[] animalDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IAnimal animal = createAnimal.CreateAnimal(animalDetails);
            return animal;
        }

        private IFood CreateFood() 
        {
            string[] foodInfo =reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string foodType = foodInfo[0];
            int foodQuantity = int.Parse(foodInfo[1]);
            IFood food = createFood.CreateFood(foodType,foodQuantity);

            return food;
        
        }

    }
}
