using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.interfaces;
using System.ComponentModel.Design;

public class StartUp
{
    static void Main(string[] args)
    {
        string command = string.Empty;
        List<string> birthdays = new List<string>();

        while ((command = Console.ReadLine())!= "End") 
        { 
          string[] commands =  command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            if (commands[0] == "Pet")
            {
                IBirthdateable pet = new Pet(commands[1], commands[2]);
                birthdays.Add(pet.Birthday);
            }
            else if (commands[0] == "Citizen")
            {
                IBirthdateable human = new Human(commands[1], int.Parse(commands[2]),
                   commands[3], commands[4]);
                birthdays.Add(human.Birthday);
            }
            else { continue; }
        
        }

        string year = Console.ReadLine();

        foreach (var birhthday in birthdays)
        {
            if (birhthday.Contains(year))
            {
                Console.WriteLine(birhthday);
            }
        }

    }
}
