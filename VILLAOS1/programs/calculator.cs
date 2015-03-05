﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace VillaOS1
{
    public class ﻿calculator
    {

        public static void Calculator()
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
            if (sign == "+")
            {
                sum = numbers[1] + numbers[2] + numbers[3];
            }
            if (sign == "-")
            {
                sum = numbers[1] - numbers[2] - numbers[3];
            }
            Console.WriteLine(sum);
            command.commands();

        }
    }
}

