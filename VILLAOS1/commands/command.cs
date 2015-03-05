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
            Console.WriteLine("Please enter a command");
            var command = Console.ReadLine();
            Console.WriteLine(command);
            if (command == "calculator")
            {
                calculator.Calculator();
            }
            else if (command == "read")
            {
                Filesystem.read();
            }
            else if (command == "write")
            {
                Filesystem.write();
            }
            else
            {
                Console.WriteLine("command not found");
            }
        }
    }
}
