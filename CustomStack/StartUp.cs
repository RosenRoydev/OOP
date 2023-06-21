using CustomStack;

public class StartUp
{
    static void Main(string[] args)
    {
        StackOfStrings words = new StackOfStrings();

        Console.WriteLine(words.IsEmpty());

        words.AddRange(new string[] { "Hi", "how", "are", "you" });
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Pop());
    }
}