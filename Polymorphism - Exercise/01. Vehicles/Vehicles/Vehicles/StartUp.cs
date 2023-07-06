using Vehicles.Models;

public class StartUp
{
    static void Main(string[] args)
    {
        string[] carDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Car vehicle = new Car(double.Parse(carDetails[1]), double.Parse(carDetails[2]));
        string[] truckDetails = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
        Truck vehicle1 = new Truck(double.Parse(truckDetails[1]), double.Parse(truckDetails[2]));

        int counter = int.Parse(Console.ReadLine());

        for (int i = 0; i < counter; i++)
        {
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (commands[0] == "Drive")
            {
                double distance = double.Parse(commands[2]);
                if (commands[1] ==  "Car")
                {

                    Console.WriteLine(vehicle.Drive(distance)); 
                }
                else if (commands[1] =="Truck")
                {
                    Console.WriteLine(vehicle1.Drive(distance)) ;
                }
                
            }
            else if (commands[0] == "Refuel")
            {
                double fuel = double.Parse(commands[2]);
                if (commands[1] == "Car")
                {

                    vehicle.Refuel(fuel);
                }
                else if (commands[1] == "Truck")
                {
                    vehicle1.Refuel(fuel);
                }
            }
        }

        Console.WriteLine(vehicle);
        Console.WriteLine(vehicle1);




    }
}