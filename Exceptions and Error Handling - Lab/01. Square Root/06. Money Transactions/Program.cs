Dictionary<string,double> bankAccounts = new Dictionary<string,double>();

string[] acountDetails = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

foreach (string acount in acountDetails)
{
    string[] input = acount.Split("-",StringSplitOptions.RemoveEmptyEntries).ToArray();
    string bankAcount = input[0];
    double sum = double.Parse(input[1]);

    if (!bankAccounts.ContainsKey(bankAcount))
    {
        bankAccounts.Add(bankAcount, sum);
    }
}
string command;
while ((command = Console.ReadLine())!= "End") 
{
    string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    try
    {
        if (commands[0] == "Deposit")
        {
            string bankAccount = commands[1];
            double sumForAdd = double.Parse(commands[2]);
            if (bankAccounts.ContainsKey(bankAccount))
            {
                bankAccounts[bankAccount] += sumForAdd;
            }
            else
            {
                throw  new IndexOutOfRangeException(bankAccount);
            }
            Console.WriteLine($"Account {bankAccount} has new balance: {bankAccounts[bankAccount]:f2}");
        }
        else if (commands[0] == "Withdraw")
        {
            string bankAccount = commands[1];
            double sumForDecrease = double.Parse(commands[2]);
            if (bankAccounts.ContainsKey(bankAccount))
            {
                if (sumForDecrease > bankAccounts[bankAccount])
                {
                    throw new ArithmeticException();
                }
                bankAccounts[bankAccount] -= sumForDecrease;
                Console.WriteLine($"Account {bankAccount} has new balance: {bankAccounts[bankAccount]:f2}");
            }
            else
            {
                throw new IndexOutOfRangeException(bankAccount);
            }
        }
        else
        {
            throw new ArgumentException();
        }

    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Invalid account!");

    }
    catch (ArithmeticException)
    {
        Console.WriteLine("Insufficient balance!");
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Invalid command!");
    }
    Console.WriteLine("Enter another command");

}
