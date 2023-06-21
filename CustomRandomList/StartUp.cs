using CustomRandomList;

public class StartUp
{
    static void Main(string[] args)
    {
        RandomList strings = new RandomList();
        strings.Add("Opel");
        strings.Add("BMW");
        strings.Add("Audi");
        strings.Add("Lada");
   
        Console.WriteLine(strings.RandomString());



    }

} 