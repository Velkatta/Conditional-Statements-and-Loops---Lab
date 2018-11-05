using System;

namespace _02._Passed_or_Failed
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
