using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string [] tokkens = args.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string command = tokkens[0];
            string[] details = tokkens.Skip(1).ToArray();

            Type typeCommand = Assembly.GetEntryAssembly().GetTypes().FirstOrDefault(
                c => c.Name == $"{command}Command");
            if (typeCommand == null) 
            {
                throw new ArgumentException("Invalid command!");
            }

            ICommand commandForWork = Activator.CreateInstance(typeCommand) as ICommand;


            string result = commandForWork.Execute(details);
            return result.ToString();
        }
    }
}
