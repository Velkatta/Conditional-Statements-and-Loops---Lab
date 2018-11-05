using System;

namespace _11._Odd_Number
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Please write an odd number.");                  
                }
                if (n % 2 == 1)
                {
                    Console.WriteLine($"The number is: {n}");
                    return;
                }
            }          
        }
    }
}