using System;

namespace _10._Multiplication_Table_Two
{
    class MultyTwo
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{first} X {second} = {first * second}");
                second++;
            }
            while (second <= 10);
        }
    }
}