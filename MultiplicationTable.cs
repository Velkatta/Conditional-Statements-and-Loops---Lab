using System;

namespace _09._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            while (count <= 10)
            {
                Console.WriteLine($"{n} X {count} = {n * count}");
                count++;
            }
        }
    }
}