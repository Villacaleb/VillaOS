﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace VillaOS1
{
    public class command {

        public static void commands()
        {
            //This would be the main command handler.
            Console.WriteLine("Command Loaded");
            var command = Console.ReadLine();
            Console.WriteLine(command);
            if (command == "calculator")
            {
                calculator.Calculator();
            }
            if (command == "load")
            {
                Filesystem.read();
            }
        }
    }
}
