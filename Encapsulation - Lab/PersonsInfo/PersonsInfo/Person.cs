//FirstName: string
// LastName: string
// Age: int
// ToString(): string - override

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;


        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age >= 30)
            {
                Salary += (percentage * Salary) / 100;
            }
            else
            {
                Salary += (percentage * Salary) / 200;
            }
        }
        //Andrew Williams receives 2640.00 leva
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva";
        }
    }
}
