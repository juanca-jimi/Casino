using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfRoulette
{
    class PlayRoulette
    {
        private static void typeBet(int bet)
        {
            YourPot yourCase = new YourPot();
            Console.WriteLine($"\tYou're betting {bet:c}\t\nHow do you wish to play it?\n");
            Console.WriteLine("1. Numbers: the number of the bin\n" +
                                "2.Evens / Odds: even or odd numbers\n" +
                                "3.Reds / Blacks: red or black colored numbers\n" +
                                "4.Lows / Highs: low(1 – 18) or high(19 – 38) numbers\n" +
                                "5.Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36\n" +
                                "6.Columns: ﬁrst, second, or third columns\n" +
                                "7.Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24\n" +
                                "8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26\n" +
                                "9.Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36\n" +
                                "10.Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 /");
            try
            {
                yourCase.CurrentTypeBet = Convert.ToInt32(Console.ReadLine());
                outcome(yourCase.CurrentTypeBet, bet);
            }
            catch (Exception)
            {
                Console.Clear();
                //Will call method recursively if entry is not integer
                Console.WriteLine("Please enter a valid bet\n");
                typeBet(bet);
            }
        }
        public static void playAgain(bool win, int bet)
        {
            if (win)
            {
                Console.WriteLine("Do you wish to push your luck? y/n");
                try
                {
                    char play = Convert.ToChar(Console.ReadLine().ToLower());
                    if (play == 'y')
                    {
                        typeBet(bet: bet);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Thanks for playing, you take home {bet:c}");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please enter \"y\" or \"n\"\n");
                    playAgain(win, bet);
                }
            }
        }
    }
}
