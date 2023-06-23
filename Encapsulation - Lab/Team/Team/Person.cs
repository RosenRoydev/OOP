namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;


        }

        public string FirstName
        {
            get { return firstName; }

            set
            {
                if (value.Length<3) 
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
               
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!"
);
                }
                this.lastName = value;
            }

        }

        public int Age
        {
            get => this.age;

            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
               
                this.age = value;
            }
        }
        public decimal Salary
        {
            get => this.salary;

            set
            {
                if (value <= 460)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
               
                this.salary = value;
            }
        }
        public void IncreaseSalary(decimal percentage)
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