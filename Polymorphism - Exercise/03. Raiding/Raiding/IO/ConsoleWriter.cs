using Raiding.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.IO
{
    public class ConsoleWriter : IWriter
    {
        void IWriter.ConsoleWriter(string message) => Console.WriteLine(message);
        
        
    }
}
