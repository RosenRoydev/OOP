using VehiclesExtension.IO.Interfaces;

using VehiclesExtension.IO;
using VehiclesExtension.IO.Interfaces;
using VehiclesExtension.Factory.Interface;
using VehiclesExtension.Factory;
using VehiclesExtension.Engine.Interface;
using VehiclesExtension.Engine;

IReader reader = new Reader();
IWriter writer = new Writer();
ICreateVehicle createVehicle = new CreateVehicle();

IEngine engine = new Engine(reader, writer,createVehicle);

engine.Engine();
