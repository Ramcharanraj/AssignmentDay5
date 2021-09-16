using System;

namespace AddAndSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
