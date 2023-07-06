using WildFarm.Core;
using WildFarm.Core.Interface;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IAnimalFactory createAnimal = new AnimalFactory();
IFoodFactory createFood = new FoodFactoy();

IEngine engine = new Engine(reader, writer, createAnimal, createFood);
engine.Run();