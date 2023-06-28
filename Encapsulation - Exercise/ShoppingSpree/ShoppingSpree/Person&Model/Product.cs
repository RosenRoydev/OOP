using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Person_Model
{
    public class Product
    {
        private string name;
        private decimal cost;


        public Product(string name, decimal cost) 
        { 
          Name = name;
          Cost = cost;
        
        }

        public string Name
        {
            get => this.name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public  decimal Cost
        {
            get => this.cost;

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.cost = value;
            }
        }



    }
}
