using System;

namespace Leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1;
            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            if ((year % 400 == 0) && (year % 100 == 0) && (year % 4 == 0))
                Console.WriteLine("Is a leap year " + year);
            else
                Console.WriteLine("Is not a leapyear " + year);
        } 
    }
}
