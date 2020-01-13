using System;
using System.Collections.Generic;

namespace FunctionalPrograms

{
    class FlipCoin
    {
       public static void GetPercentage()
        {
            Console.WriteLine("Enter the Number of fliping Coins: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int head = 0;
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                int gN = random.Next(2);
                if (gN < 1)
                    head++;
            }
            int percent = (head * 100) / N;
            Console.WriteLine("Percentage of Heads = " + percent+"%");
            Console.WriteLine("Percentage of Tails = " + (100 - percent)+"%");
        }
    }
}
