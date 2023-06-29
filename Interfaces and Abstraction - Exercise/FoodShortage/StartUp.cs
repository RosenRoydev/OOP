using FoodShortage.Models;
using FoodShortage.Models.Interfaces;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Citizen> buyers = new List<Citizen>();
        List <Rebel> rebels = new List<Rebel>();

        for (int i = 0; i < n; i++) 
        {
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (commands.Length == 4)
            {
                Citizen buyer = new Citizen(commands[0], int.Parse(commands[1]),
                    commands[2], commands[3]);
                buyers.Add(buyer);
            }
            else
            {
                Rebel buyer = new Rebel(commands[0], int.Parse(commands[1]), commands[2]);
                rebels.Add(buyer);  
            }
        
        }

        string name = string.Empty;
        while ((name = Console.ReadLine()) != "End")
        {
            Citizen searchedPerson = buyers.FirstOrDefault(x => x.Name == name);
            Rebel  searchedRebel = rebels.FirstOrDefault(x => x.Name == name);

            if (searchedPerson != null)
            {
                searchedPerson.BuyFood();
            }
            else if (searchedRebel != null)
            {
                searchedRebel.BuyFood();
            }

            else
            {
                continue;
            }
        }

        int sum = 0;
        foreach (var buyer in buyers)
        {
            sum += buyer.Food;
        }
        foreach (var rebel in rebels)
        {
            sum += rebel.Food;
        }

        Console.WriteLine(sum);

    }
}
