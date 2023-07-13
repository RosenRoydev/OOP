﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core.Models
{
    public class ExitCommand : ICommand
    {
        private const int exitcommand = 0;
        public string Execute(string[] args)
        {
            Environment.Exit(exitcommand);
            return null;
        }
    }
}
