using Border_Control.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id) 
        { 
          Model = model;
            Id = id;
        }
        public string Model { get; private set; }
        public string Id {get; private set;}
    }
}
