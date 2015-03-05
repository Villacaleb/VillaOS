﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace VillaOS1
{
    public class Kernel : Sys.Kernel
    {

        /*
         TODO Alpha 1:
         * Password and username system.
         * Calculator
         * Filing system (Cancled, is on hold till further noticed)
         * and more
         */

        // Notes:
        // List do not work in Cosmos, use normal array's
        // Convert.ToInt32, Convert.ToInt64, etc do not work in Cosmos, use Int32.Parse();
        // The file system is gonna be a big and long task, Caleb will be in lead Development of it.
        // Bailey will start the basics of VCompiler soon.
        String username = "admin";
        String password = "adminpass";
        bool login = false;
        protected override void BeforeRun()
        {
            Console.WriteLine("VillaOS starting...");
            Console.WriteLine("VillaOS was created by Caleb Bird and VillaOS contributors.");
            Console.WriteLine("VillaOS started.");
        }

        protected override void Run()
        {
            if (login == false)
            {
                Console.Write("Username:");
                var input = Console.ReadLine();
                if (input == username)
                {
                    Console.WriteLine("Password:");
                    input = Console.ReadLine();
                    if (input == password)
                    {
                        Console.WriteLine("Logining in.."); // After logining in, it will load everything,
                        login = true;
                        Console.WriteLine("Loading Command...");
                        Command.commands();

                    }
                }
            }
        }

    }
    public class Command
    {
        public static void commands()
        {
            //This would be the main command handler.
            var command = Console.ReadLine();
            Console.WriteLine(command);
            if (command == "calculator")
            {
                calculator();
            }
            if(command == "load")
            {
                load();
            }
        }
        public static void calculator()
        {
            int[] numbers = new int[3]; 
            int sum = 0;
            Console.WriteLine("Adding or Subtracting? (+ or -)");
            var sign = Console.ReadLine();
            Console.WriteLine("Number:");
            string input = Console.ReadLine();
            numbers[1] = Int32.Parse(input);
            Console.WriteLine("Number: ");
            input = Console.ReadLine();
            numbers[2] = Int32.Parse(input);
            Console.WriteLine("Number: ");
            input = Console.ReadLine();
            numbers[3] = Int32.Parse(input);
            if(sign == "+")
            {
                sum = numbers[1] + numbers[2] + numbers[3];
            }
            if(sign == "-")
            {
                sum = numbers[1] - numbers[2] - numbers[3];
            }
            Console.WriteLine(sum);
            commands();
            


        }
        public static void load()
        {
            
        }
    }
}