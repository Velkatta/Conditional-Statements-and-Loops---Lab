﻿using System;

namespace _01._Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
