using System;

namespace PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Enter a number:");//input from User
            num = Convert.ToInt32(Console.ReadLine());
            int result = num * 2; //num*2 if 2*2==4
            Console.WriteLine(result);//Op
            Console.ReadLine();
        }
    }
}
