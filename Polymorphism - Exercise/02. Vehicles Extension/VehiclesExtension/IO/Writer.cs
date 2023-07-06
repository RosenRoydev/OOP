using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.IO.Interfaces;

namespace VehiclesExtension.IO
{
    public class Writer : IWriter
    {
        public void Write(string str) => Console.WriteLine(str);
        
        
    }
}
