using PersonsInfo;
using System.Globalization;

public class StartUp
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstName = personInfo[0];
            string lastName = personInfo[1];
            int age = int.Parse(personInfo[2]);
            decimal salary = decimal.Parse(personInfo[3]);
            Person person = new Person(firstName, lastName, age, salary);
            people.Add(person);
        }
        decimal  percentage = decimal.Parse(Console.ReadLine());

        foreach (var person in people) 
        {
            person.IncreaseSalary(percentage);
            Console.WriteLine(person.ToString());

        }


    }
}
