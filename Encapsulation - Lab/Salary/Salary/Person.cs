namespace PersonsInfo
{
    public class Person
    {


        public Person(string firstName, string lastName,int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
            

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; set; }

        public void  IncreaseSalary (decimal percentage)
        {
            if (this.Age >= 30)
            {
               this.Salary += percentage * Salary / 100;
            }
            else
            {
                this.Salary += percentage * Salary / 200;
            }
        }
        //Andrew Williams receives 2640.00 leva
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }

}
