using Raiding.Core.Interface;
using Raiding.Factory;
using Raiding.Factory.Interface;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private ICollection<IHero> heroes;
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly ICreateHero createHero;

        public Engine (IWriter writer, IReader reader, ICreateHero createHero)
        {
            this.writer = writer;
            this.reader = reader;
            this.createHero = createHero;

            heroes = new List<IHero> () ;
        }
        public void Run()
        {
            int heroesCount = int.Parse(reader.ReadLine());

            while (heroesCount > 0)
            {
                

                try
                {
                    
                    string heroName = reader.ReadLine();
                    string heroType = reader.ReadLine();

                    IHero hero = createHero.CreateHero(heroType, heroName);
                    heroesCount--;
                    heroes.Add(hero);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int bossPower = int.Parse(reader.ReadLine());

            if (heroes.Sum(h => h.Power) >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
            
        }
    }
}
