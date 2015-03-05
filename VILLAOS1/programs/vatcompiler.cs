﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
namespace VillaOS1
{
    public class vatcompiler
    {
        public static string commandarg0 = "";
        public static string commandarg1 = "";
        public static string commandarg2 = "";
        public static string commandarg3 = "";
        public static string commandarg4 = "";
        public static int timer = 0;


        public static void compiler()
        {
            Console.WriteLine("Command?");
            commandarg0 = Console.ReadLine();
            if (commandarg0 == "input")
            {
                commandarg1 = Console.ReadLine();

                commandarg2 = Console.ReadLine();
                if (commandarg2 == "open")
                {
                    commandarg3 = Console.ReadLine();
                    if (commandarg3 == "calculator")
                    {
                        var input = Console.ReadLine();
                        if(input == commandarg1)
                        {
                            calculator.Calculator();
                        }
                    }
                    if(commandarg3 == "read")
                    {
                        Filesystem.read();
                        var input = Console.ReadLine();
                        if (input == commandarg1)
                        {
                            Filesystem.read();
                        }
                    }
                    if(commandarg3 == "write")
                    {
                        Filesystem.write();
                        var input = Console.ReadLine();
                        if (input == commandarg1)
                        {
                            Filesystem.write();
                        }
                    }
                }

            }

        }

    }
}

