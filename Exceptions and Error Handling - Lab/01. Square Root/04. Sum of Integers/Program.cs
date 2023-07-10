string[] numbers = Console.ReadLine().Split(" ");
int sum = 0;


for (int i = 0; i < numbers.Length; i++)
{
	try
	{
		int number = int.Parse(numbers[i]);



		sum += number;
	
	}
	catch (FormatException)
	{

		Console.WriteLine($"The element '{numbers[i]}' is in wrong format!");
	}
	catch (OverflowException)
	{
		Console.WriteLine($"The element '{numbers[i]}' is out of range!");
	}
	finally { Console.WriteLine($"Element '{numbers[i]}' processed - current sum: {sum}"); }
}
Console.WriteLine($"The total sum of all integers is: {sum}");


