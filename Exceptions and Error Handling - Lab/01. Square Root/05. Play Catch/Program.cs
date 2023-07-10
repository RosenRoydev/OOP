int[] numbersForManipulation= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

int exceptionCounter  = 0;

string command = Console.ReadLine();
while (exceptionCounter != 3)
{
	string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	string activity = input[0];
	try
	{
		if (input[0] == "Replace")
		{
			int index = int.Parse(input[1]);
			int element = int.Parse(input[2]);
			numbersForManipulation[index] = element;

		}
		else if (input[0] == "Print")
		{
			int startIndex = int.Parse(input[1]);
			int endIndex = int.Parse(input[2]);
			List<int> newNumbers = new List<int>();
			for (int i = startIndex; i <= endIndex; i++)
			{
				newNumbers.Add(numbersForManipulation[i]);
			}
            Console.WriteLine(string.Join(", ",newNumbers));
        }
		else
		{
			int index = int.Parse(input[1]);
			Console.WriteLine(numbersForManipulation[index]);
		}

	}
	catch (IndexOutOfRangeException)
	{
		exceptionCounter++;
        Console.WriteLine("The index does not exist!");
    }
	catch (FormatException)
	{
        exceptionCounter++;
        Console.WriteLine("The variable is not in the correct format!");
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(", ",numbersForManipulation));