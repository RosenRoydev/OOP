using Border_Control.Models;
using Border_Control.Models.Interfaces;

public class StartUp
{
    static void Main(string[] args)
    {
        string command = string.Empty;
        List<string> IDs = new List <string> ();

        while((command= Console.ReadLine())!= "End")
        {
            string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if(commands.Length == 3)
            {
                IIdentifiable human = new Human(commands[0], int.Parse(commands[1]), commands[2]);
                IDs.Add(human.Id);
            }

            else 
            {
                IIdentifiable robot = new Robot(commands[0], commands[1]);
                IDs.Add(robot.Id);
                
            }

        }
        string fakeId = Console.ReadLine();


        foreach (var id in IDs)
        {
            if (id.EndsWith(fakeId))
            {
                Console.WriteLine(id);
            }
        }
    }
}
