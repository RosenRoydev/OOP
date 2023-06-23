﻿using PersonsInfo;
using System.Data;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> workers = new List<Person>(); 

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ");
                Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]),
                    decimal.Parse(personInfo[3]));
                workers.Add(person);
            }

            decimal percentage = decimal.Parse(Console.ReadLine());
            foreach (Person person in workers)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person.ToString());
            }
        }
    }
}