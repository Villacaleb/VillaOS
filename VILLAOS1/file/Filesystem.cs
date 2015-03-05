﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.Debug;
using Cosmos.Core;

namespace VillaOS1
{
    public class Filesystem {

            public static string[] Files = new string[100]; // 100 files is the limit
			public static void read(){
                Files[1] = "g";
                Console.WriteLine("What file do you want to open?");
                var input = Console.ReadLine();
                int i = Int32.Parse(input);
                Console.WriteLine(Files[i]);
            }
    
    } 
    
}