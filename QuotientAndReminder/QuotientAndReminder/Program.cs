using System;

namespace QuotientAndReminder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor");
            int divisor = int.Parse(Console.ReadLine());
            //Assigning Values of dividend and divisor
            //int dividend = 5;
            //int divisor = 5;

            //Applying dividend and divisor by giving assignin values Quo and rem
            double Quo = dividend / divisor;
            double rem = dividend % divisor;

            //Print Quo and rem
            Console.WriteLine("Quotient = " + Quo);
            Console.WriteLine("Remainder =" + rem);
        }
    }
}
