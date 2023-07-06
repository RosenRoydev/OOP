using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factory.Interface
{
    public interface ICreateHero
    {
        IHero CreateHero(string type, string name);
        
    }
}
