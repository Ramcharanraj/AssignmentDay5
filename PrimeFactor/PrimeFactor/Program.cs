using System;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter the your Interger");
            a = int.Parse(Console.ReadLine());
            for(b =1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " +a );
                }
            }
        }
    }
}
