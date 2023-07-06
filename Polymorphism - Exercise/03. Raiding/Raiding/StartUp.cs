using Raiding.Core;
using Raiding.Core.Interface;
using Raiding.Factory;
using Raiding.Factory.Interface;
using Raiding.IO;
using Raiding.IO.Interfaces;
using Raiding.Factory;




IWriter writer = new ConsoleWriter();
IReader reader = new ConsoleReader();
ICreateHero createHero = new CreateNewHero();

IEngine engine = new Engine(writer,reader,createHero);


engine.Run();
   

