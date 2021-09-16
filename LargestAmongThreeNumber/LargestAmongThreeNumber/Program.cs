using System;

namespace LargestAmongThreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intialization of variables
            int num1, num2, num3;

            //Ask for Numbers
            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Logic to check 1st is Large Number
            if (num1 >= num2 && num1 >= num3)
            {
                Console.Write("The 1st Number is the greatest among three ");
            }

            //else check for Second Number
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.Write("The 2nd Number is the greatest among three");
            }

            //If not 1st and 2nd then it is 3rd Number
            else
            {
                Console.Write("The 3rd Number is the greatest among three");


            }
        }
    }
}