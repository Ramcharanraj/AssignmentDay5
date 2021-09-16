using System;

namespace Swaping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intializing the values to the variables
            int a = 10, b = 30, temp;

            //Before Swapping the Numbers
            Console.WriteLine("Given Numbers are " + a + " b = " + b);

            //Swapping logic
            temp = a;
            a = b;
            b = temp;

            //After the Swapping the Number
            Console.WriteLine("Swapped Number is a=" + a + " b = " +b );
        }
    }
}
