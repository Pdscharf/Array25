﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            foreach (int i in numbers)
            {
                Console.WriteLine("Element Value = " + i);
            }
            {
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
