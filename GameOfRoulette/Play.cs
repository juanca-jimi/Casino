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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
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
                //TODO: Try catch blocks for inputs from user
                //TODO: Account for 0 & 00
                //TODO: Change arrays and string indentifiers to have more intuitive names
                //TODO: Turn on garbage collection 
                //  at top of each case to remove unnecessary arrays taking memory
                case 1:
                    //TODO: Do not allow any numbers outside of 1-38
                    Console.Clear();
                    Console.WriteLine("Choose the number you wish to bet on");
                    int binNumber = Convert.ToInt32(Console.ReadLine());
                    landedOn(ballLand);
                    if (ballLand == binNumber)
                    {
                        win = true;
                        youWin(bet: bet, howMuch: 35);
                        bet *= 35;
                    }
                    else sorry();
                    playAgain(win, bet);
                    break;
                case 2:
                    int[] evens = {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36 };
                    int[] odds = { 1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35};
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on even or odd?");
                    string evenOrOdd = Console.ReadLine().ToLower();
                    if (evenOrOdd=="even")
                    {   
                        landedOn(ballLand);
                        for (int i = 0; i < evens.Length; i++)
                        {
                            if (ballLand == evens[i])
                            {
                                youWin(bet: bet, howMuch: 1);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (evenOrOdd=="odd")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < odds.Length; i++)
                        {
                            if(ballLand == odds[i])
                            {
                                youWin(bet: bet, howMuch: 1);
                                win = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    playAgain(win, bet);
                    break;
                case 3:
                    //TODO: Change array to correct reds and blacks
                    int[] blacks = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    int[] reds = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on red or black?");
                    string redOrBlack = Console.ReadLine().ToLower();
                    if (redOrBlack == "red")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < reds.Length; i++)
                        {
                            if (ballLand == reds[i])
                            {
                                youWin(bet: bet, howMuch: 1);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (redOrBlack == "black")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < blacks.Length; i++)
                        {
                            if (ballLand == blacks[i])
                            {
                                youWin(bet: bet, howMuch: 1);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    playAgain(win, bet);
                    break;
                case 4:
                    //TODO: Change lows and highs to correct lows and highs
                    int[] lowsArr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    int[] highsArr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on low or high numbers?");
                    string lowOrHigh = Console.ReadLine().ToLower();
                    if (lowOrHigh == "low")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < lowsArr.Length; i++)
                        {
                            if (ballLand == lowsArr[i])
                            {
                                youWin(bet: bet, howMuch: 1);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (lowOrHigh == "high")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < highsArr.Length; i++)
                        {
                            if (ballLand == highsArr[i])
                            {
                                youWin(bet: bet, howMuch: 1);
                                win = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    playAgain(win, bet);
                    break;
                case 5:
                    //TODO: Change row thirds with correct numbers
                    
                    int[] rowThirds1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    int[] rowThirds2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    int[] rowThirds3 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on top(1-12), middle(13-24), or bottom dozens(25-36)?");
                    string topMiddleBottom = Console.ReadLine().ToLower();
                    if (topMiddleBottom == "top")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds1.Length; i++)
                        {
                            if (ballLand == rowThirds1[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (topMiddleBottom == "middle")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds2.Length; i++)
                        {
                            if (ballLand == rowThirds2[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else if (topMiddleBottom == "bottom")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds3.Length; i++)
                        {
                            if (ballLand == rowThirds3[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    landedOn(ballLand);
                    playAgain(win, bet);
                    break;
                case 6:
                    //TODO: Change columns with correct numbers
                    //TODO: Change for loops and if statements to match
                    int[] column1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    int[] column2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    int[] column3 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on top(1-12), middle(13-24), or bottom dozens(25-36)?");
                    string leftMiddleRight = Console.ReadLine().ToLower();
                    if (leftMiddleRight == "top")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds1.Length; i++)
                        {
                            if (ballLand == rowThirds1[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (topMiddleBottom == "middle")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds2.Length; i++)
                        {
                            if (ballLand == rowThirds2[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else if (topMiddleBottom == "bottom")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds3.Length; i++)
                        {
                            if (ballLand == rowThirds3[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    landedOn(ballLand);
                    playAgain(win, bet);
                    break;
                case 7:
                    //TODO: Change streets with correct numbers
                    //TODO: implement correct number of streets
                    //TODO: Add for loops for additional steets
                    //TODO: Change win payouts
                    //TODO: change if statements and loops to match
                    int[] rowThirds1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    int[] rowThirds2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    int[] rowThirds3 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on top(1-12), middle(13-24), or bottom dozens(25-36)?");
                    string topMiddleBottom = Console.ReadLine().ToLower();
                    if (topMiddleBottom == "top")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds1.Length; i++)
                        {
                            if (ballLand == rowThirds1[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (topMiddleBottom == "middle")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds2.Length; i++)
                        {
                            if (ballLand == rowThirds2[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else if (topMiddleBottom == "bottom")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds3.Length; i++)
                        {
                            if (ballLand == rowThirds3[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    landedOn(ballLand);
                    playAgain(win, bet);
                    break;
                case 8:
                    //TODO: Change DOUBLE streets with correct numbers
                    //TODO: implement correct number of streets
                    //TODO: Add for loops for additional steets
                    //TODO: Change win payouts
                    //TODO: change if statements and loops to match
                    int[] rowThirds1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    int[] rowThirds2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    int[] rowThirds3 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    Console.Clear();
                    Console.WriteLine("Do you wish to bet on top(1-12), middle(13-24), or bottom dozens(25-36)?");
                    string topMiddleBottom = Console.ReadLine().ToLower();
                    if (topMiddleBottom == "top")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds1.Length; i++)
                        {
                            if (ballLand == rowThirds1[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                        //TODO: figure out way to show if player won that they're going to play again
                        sorry();
                    }
                    else if (topMiddleBottom == "middle")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds2.Length; i++)
                        {
                            if (ballLand == rowThirds2[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else if (topMiddleBottom == "bottom")
                    {
                        landedOn(ballLand);
                        for (int i = 0; i < rowThirds3.Length; i++)
                        {
                            if (ballLand == rowThirds3[i])
                            {
                                youWin(bet: bet, howMuch: 2);
                                win = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //TODO:Recursively ask again
                    }
                    landedOn(ballLand);
                    playAgain(win, bet);
                    break;
                case 9:
                    //TODO: Implement splits 
                    landedOn(ballLand);
                    playAgain(win, bet);
                    break;
                case 10://TODO: Implement corners
                    landedOn(ballLand);
                    playAgain(win, bet);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("PLEASE TRY AGAIN WITH VALID CHOICE\n");
                    typeBet(bet);
                    break;
            }
        }
        private static void youWin(int howMuch, int bet) => Console.WriteLine($"You won {bet*howMuch}!!!" +
            $"\n\tYour your pot is now{howMuch*bet+bet}");
        private static void landedOn(int ballLand) => Console.WriteLine($"Ball landed on {ballLand}!");
        private static void sorry()
        {
            Console.WriteLine("Better luck next time!\n\tThanks for playing!");
            Console.ReadKey();
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
