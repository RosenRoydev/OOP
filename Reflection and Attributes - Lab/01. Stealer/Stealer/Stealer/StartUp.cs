using Stealer;
using System;

public class StartUp
{
    public static void Main(string[] args)
    {
       Spy spy = new Spy();
        spy.AnalyzeAccessModifiers("Hacker");
        string result = spy.AnalyzeAccessModifiers("Hacker");
        Console.WriteLine(result);
    }
}
