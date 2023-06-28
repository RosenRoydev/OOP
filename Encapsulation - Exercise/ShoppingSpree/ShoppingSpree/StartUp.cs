using ShoppingSpree.Person_Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree;
public class StartUp
{
    static void Main(string[] args)
    {
        
        
        
        List<Product> productsList = new List<Product>();
        List<Person> custumers = new List<Person>();

        try
        {
            string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (string person in people)
            {
                string[] custumerInfo = person.Split("=",StringSplitOptions.RemoveEmptyEntries).
                    ToArray();
                Person custumer = new Person(custumerInfo[0], decimal.Parse(custumerInfo[1]));
                custumers.Add(custumer);

            }
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (string product in products) 
            {
                string[] productsDetails = product.Split("=", StringSplitOptions.RemoveEmptyEntries);

                Product newProduct = new Product(productsDetails[0], decimal.Parse(productsDetails[1])); 
                productsList.Add(newProduct);
            }
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
            return;
        }

        string commands ;
        while ((commands  = Console.ReadLine()) != "END") 
        {
            string[] custumerProduct = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string custumerName = custumerProduct[0];
            string neededProduct= custumerProduct[1];

            Person custumer = custumers.FirstOrDefault(c => c.Name == custumerName);   
            Product product = productsList.FirstOrDefault(p => p.Name == neededProduct);

           
            
                Console.WriteLine(custumer.AddProduct(product));
            
            
            
        
        }

        foreach (var custumer in custumers)
        {
            Console.WriteLine(custumer.ToString());
        }
    }
}