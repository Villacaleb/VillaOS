using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace VillaOS
{
    public class Kernel : Sys.Kernel
    {

        /*
         TODO Alpha 1:
         * Password and username system.
         * Calculator
         * Filing system
         * and more
         */
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
        }
    }
}
