using Border_Control.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control.Models
{
    public class Human : IIdentifiable
    {
        public Human(string name, int age, string id) 
        { 
         Name = name;
            Age = age;
            Id = id;
        
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
    }
}
