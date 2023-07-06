using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Engine.Interface;
using VehiclesExtension.Factory;
using VehiclesExtension.Factory.Interface;
using VehiclesExtension.IO;
using VehiclesExtension.IO.Interfaces;
using VehiclesExtension.Models;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Engine
{
    public class Engine : IEngine
    {

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICreateVehicle createVehicle;

        private readonly ICollection<IVehicle> vehicles;

        public Engine(IReader reader, IWriter writer, ICreateVehicle createVehicle)
        {
          this.reader = reader;
            this.writer = writer;
            this.createVehicle = createVehicle;

            vehicles = new List<IVehicle>();
        }



        void IEngine.Engine()
        {
            vehicles.Add(CreateNewVehicle());
            vehicles.Add(CreateNewVehicle());
            vehicles.Add(CreateNewVehicle());

            int commandCount = int.Parse(reader.Read());

            for (int i = 0; i < commandCount; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch (ArgumentException ex)
                {

                    writer.Write (ex.Message);
                }
            }

            foreach (var vehicle in vehicles)
            {
                writer.Write(vehicle.ToString());
            }

        }

        private void ProcessCommand()
        {
            string[] tokkens = reader.Read().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = tokkens[0];
            string vehicleType = tokkens[1];

          
                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType );

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");

            }

            else if (command == "Refuel")
            {
                double litters = double.Parse(tokkens[2]);
                vehicle.Refuel(litters);
                
            }
            else if (command == "Drive")
            {
                double distance = double.Parse(tokkens[2]);
                writer.Write(vehicle.Drive(distance));
                    
            }
            else if(command == "DriveEmpty")
            {
                double distance = double.Parse(tokkens[2]);
                writer.Write(vehicle.Drive(distance, false));
            }

            
        }

        private IVehicle CreateNewVehicle()
        {
            string[] tokens = reader.Read().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return createVehicle.Create(tokens[0], double.Parse(tokens[1]),
               double.Parse(tokens[2]) ,double.Parse(tokens[3]));
        }
    }


}



