using System;

namespace _03._Back_in_30_Minutes
{
    class BackInMinutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (hours <= 9)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
                return;
            }
            Console.WriteLine($"{hours:d2}:{minutes:d2}");
        }
    }
}