using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public virtual int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
