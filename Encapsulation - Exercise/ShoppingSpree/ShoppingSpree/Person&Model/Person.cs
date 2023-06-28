using System;


namespace ShoppingSpree.Person_Model
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get => this.name;

            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public string AddProduct(Product product)
        {
            if (product.Cost <= Money)
            {
                products.Add(product);
                Money -= product.Cost;
                return $"{Name} bought {product.Name}";
            }
            else
            {
                return $"{Name} can't afford {product.Name}";
            }
        }

        public override string ToString()
        {

            string productsBag = products.Any() ? (string.Join(", ", products.Select(p => p.Name)))
                : "Nothing bought";

            return $"{Name} - {productsBag}";

        }



    }


}
