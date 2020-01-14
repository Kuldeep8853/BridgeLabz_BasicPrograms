using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms{
    public class Gambler{
        public static void FindWinLos(){
            int stake = Convert.ToInt32(Console.ReadLine());    // gambler's stating bankroll
            int goal = Convert.ToInt32(Console.ReadLine());    // gambler's desired bankroll
            int trials = Convert.ToInt32(Console.ReadLine());    // number of trials to perform

            int bets = 0;        // total number of bets made
            int wins = 0;        // total number of games won
            Random random = new Random();
            // repeat trials times
            for (int t = 0; t < trials; t++)
            {

                // do one gambler's ruin simulation
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    bets++;
                    int number = random.Next(2);
                    if (number< 0.5) 
                        cash++;     // win $1
                    else cash--;     // lose $1
                }
                if (cash == goal)
                    wins++;                // did gambler go achieve desired goal?
            }

            // print results
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("Avg # bets           = " + 1.0 * bets / trials);
        }

    }

}
