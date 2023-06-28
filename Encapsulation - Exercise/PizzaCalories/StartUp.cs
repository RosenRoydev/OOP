using PizzaCalories;
using System.Data;
namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaName= Console.ReadLine().Split();
                string[] pizzaDough = Console.ReadLine().Split();
                string nameOfPizza;
                if (pizzaName.Length == 1)
                {
                     nameOfPizza = null;
                }
                else
                {
                    nameOfPizza = pizzaName[1];
                }
               
                Dough dought = new Dough(pizzaDough[1], pizzaDough[2], double.Parse(pizzaDough[3]));

                Pizza pizza = new Pizza(nameOfPizza, dought);

                string input = Console.ReadLine();
                while (true)
                {
                    

                    if (input == "END")
                    {
                        break;
                    }

                    string[] toppingDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Topping topping = new Topping(toppingDetails[1], double.Parse(toppingDetails[2]));
                    
                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            
         

        }


    }
}


