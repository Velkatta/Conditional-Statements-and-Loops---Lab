﻿using System;

namespace _08._Sum_of_Odd_Numbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int sum = 0;
            for (int i = 1; i <= n * 2; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}