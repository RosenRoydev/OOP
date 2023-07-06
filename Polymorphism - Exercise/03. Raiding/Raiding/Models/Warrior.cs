using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int WariorPower = 100;
        public Warrior(string name) : base(name, WariorPower)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
