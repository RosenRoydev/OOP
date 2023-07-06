using Raiding.Factory.Interface;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factory
{
    public class CreateNewHero : ICreateHero
    {
        public IHero CreateHero(string type, string name)
        {
            switch (type) 
            {
                case "Druid": 
                    return new Druid (name);
                case "Paladin":
                    return new Paladin(name);
                case "Rogue":
                    return new Rogue(name);
                case "Warrior":
                    return new Warrior(name);

                default:
                    throw new NotImplementedException("Invalid hero!");







            }
        }
    }
}
