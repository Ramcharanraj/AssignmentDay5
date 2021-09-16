using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            {
                Console.WriteLine("Enter how many times to flip a coin : ");
                int Number = Convert.ToInt32(Console.ReadLine());

                for (int coin = 0; coin <= Number; coin++)
                {
                    Random random = new Random();
                    double Coin = random.NextDouble();
                    if (Coin < 0.5)
                        tails++;
                    else
                        heads++;
                }
                double TailsPercentage = (tails * 100) / Number;
                double HeadsPercentage = (heads * 100) / Number;
                Console.WriteLine("percentage of heads  is : " + HeadsPercentage);
                Console.WriteLine("percentage of tails is : " + TailsPercentage);

            }
        }
    }
}
