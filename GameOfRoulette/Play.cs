using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfRoulette
// This is an unbreakable intuitive game of roullete!
{
    class Play
    {
        static void Main(string[] args)
        {
            welcome();
        }
        public int Bet { get; set; }
        public static void welcome()
        {
            Console.WriteLine("Welcome to our roulette table\n" +
                "How much money do you wish to gamble?");
            try
            {
                //This will set the property in the YourPot Class
                YourPot originalPot = new YourPot();
                originalPot.Bet = Int32.Parse(Console.ReadLine());
                typeBet(originalPot.Bet);
            }
            catch (Exception)
            {
                //If the user does not give an integer then the method will recursively run
                Console.WriteLine("Please enter valid number\n");
                welcome();
            }
        }

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
             
        public static void outcome(int choiceOutcome, int bet)
        {
            Random random = new Random();
            //This is our random integer that decides if the player has won or lost
            int ballLand = random.Next(0, 38);
            bool win = false;
            switch (choiceOutcome)
            {
                //TODO: Try catch blocks in 
                case 1:
                    Console.Clear();
                    Console.WriteLine("Choose the number you wish to bet on");
                    int binNumber = 
                    playAgain(win, bet);
                    break;
                case 2:
                    playAgain(win, bet);
                    break;
                case 3:
                    playAgain(win, bet);
                    break;
                case 4:
                    playAgain(win, bet);
                    break;
                case 5:
                    playAgain(win, bet);
                    break;
                case 6:
                    playAgain(win, bet);
                    break;
                case 7:
                    playAgain(win, bet);
                    break;
                case 8:
                    playAgain(win, bet);
                    break;
                case 9:
                    playAgain(win, bet);
                    break;
                case 10:
                    playAgain(win, bet);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("PLEASE TRY AGAIN WITH VALID CHOICE\n");
                    typeBet(bet);
                    break;
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
                    playAgain(win,bet);
                }
            }
        }
    }
    public class YourPot
    {
        public int Bet { get; set; }
        public int CurrentTypeBet { get; set; }
    }
}
