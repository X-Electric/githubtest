﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is just a test.");
            sb.AppendLine("\nSome changes in the code.");
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
