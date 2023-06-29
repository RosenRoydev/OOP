using Telephony;

public class StartUp
{
    public static void Main(string[] args)
    {
        string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

		foreach (string phoneNumber in phoneNumbers) 
        { 
           if (phoneNumber.Length == 10)
            {
                try
                {
                    Iphonable phone = new Smartphone();

                    Console.WriteLine(phone.Call(phoneNumber));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            if (phoneNumber.Length == 7)
            {
                try
                {
                    Iphonable phone = new StationaryPhone();

                    Console.WriteLine(phone.Call(phoneNumber));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }


        }

        foreach (var url in urls)
        {
            try
            {
                IBrowseable phone = new Smartphone();
                Console.WriteLine(phone.Browse(url));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
