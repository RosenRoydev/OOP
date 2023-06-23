using PersonsInfo;
using System.Collections.Generic;
using System.Data;
using System.Threading.Channels;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Team team = new Team("SoftUni");
           

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] playersInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(playersInfo[0], playersInfo[1], int.Parse(playersInfo[2]),
                        decimal.Parse(playersInfo[3]));

                    team.AddPlayer(person);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}