using System;

namespace OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for a Numer
            Console.WriteLine("Enter the Number");

            //Take the Number from the user
            int n = int.Parse(Console.ReadLine());

            //Logic to find the no is even or odd
            if (n % 2 == 0)

                //Print Accodingly
                Console.WriteLine("It's a Even Number");

            else

                Console.WriteLine("It's a Odd Number");

        }
    }
}
        