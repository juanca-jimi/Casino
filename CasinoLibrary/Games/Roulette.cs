//using CasinoLibrary;
//using System;

//namespace GameOfRoulette
//{
//    public class Roulette : IGame
//    {
//        public bool Win { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public void DetermineInitialBet(IPlayer player)
//        {
//            Console.WriteLine("How much our we gambling on this play?");

//            //Implement Detailed Exception Handling
//            try
//            {
//                 player.CurrentBet = Convert.ToInt32(Console.ReadLine());
//            }
//            catch (Exception)
//            {
//                throw;
//            }

//        }
//        void landedOn(int ballLand)
//        {
//            Console.WriteLine($"Ball landed on {ballLand}!");
//            Console.ReadKey();
//        }

//        public void typeBet(IPlayer player)
//        {

//            Console.WriteLine($"\tYou're betting {player.CurrentBet:c}\t\n\tHow do you wish to play it?\n");
//            Console.WriteLine("1. Numbers: the number of the bin\n" +
//                                "2.Evens / Odds: even or odd numbers\n" +
//                                "3.Reds / Blacks: red or black colored numbers\n" +
//                                "4.Lows / Highs: low(1 – 18) or high(19 – 38) numbers\n" +
//                                "5.Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36\n" +
//                                "6.Columns: ﬁrst, second, or third columns\n" +
//                                "7.Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24\n" +
//                                "8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26\n" +
//                                "9.Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36\n" +
//                                "10.Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 /");

//            try
//            {
//                player.CurrentBet = Convert.ToInt32(Console.ReadLine());
//                outcome(player.CurrentBet, bet);
//            }

//            catch (Exception)
//            {
//                Console.Clear();
//                //Will call method recursively if entry is not integer
//                Console.WriteLine("Please enter a valid bet\n");
//                typeBet(bet);
//            }
//        }

//        void Outcome(int choiceOutcome, int bet)
//        {
//            Random random = new Random();
//            //This is our random integer that decides if the player has won or lost
//            int ballLand = random.Next(0, 38);
//            bool win = false;
//            switch (choiceOutcome)
//            {
//                //TODO: Try catch blocks for inputs from user
//                //TODO: Account for 0 & 00
//                //TODO: Change arrays and string indentifiers to have more intuitive names
//                //TODO: Turn on garbage collection 
//                //  at top of each case to remove unnecessary arrays taking memory
//                case 1:
//                    //Number
//                    //TODO: Do not allow any numbers outside of 1-38
//                    Console.Clear();
//                    Console.WriteLine("Choose the number you wish to bet on");
//                    int binNumber = Convert.ToInt32(Console.ReadLine());
//                    landedOn(ballLand);
//                    if (ballLand == binNumber)
//                    {
//                        win = true;
//                        bet = youWin(bet: bet, howMuch: 35);
//                        bet *= 35;
//                    }
//                    else sorry();
//                    playAgain(win, bet);
//                    break;
//                case 2:
//                    //even/odds
//                    int[] evensArr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
//                    int[] oddsArr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
//                    Console.Clear();
//                    Console.WriteLine("Do you wish to bet on even or odd?");
//                    string evenOrOdd = Console.ReadLine().ToLower();
//                    if (evenOrOdd == "even")
//                    {
//                        landedOn(ballLand);
//                        for (int i = 0; i < evensArr.Length; i++)
//                        {
//                            if (ballLand == evensArr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 1);
//                                win = true;
//                                break;
//                            }
//                        }
//                        //TODO: figure out way to show if player won that they're going to play again
//                        sorry();
//                    }
//                    else if (evenOrOdd == "odd")
//                    {
//                        landedOn(ballLand);
//                        for (int i = 0; i < oddsArr.Length; i++)
//                        {
//                            if (ballLand == oddsArr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 1);
//                                win = true;
//                                break;
//                            }
//                        }
//                    }
//                    else
//                    {
//                        //TODO:Recursively ask again
//                    }
//                    playAgain(win, bet);
//                    break;
//                case 3:
//                    //Reds/Blacks
//                    //(COMPLETE)TODO: Change array to correct reds and blacks
//                    int[] blacksArr = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
//                    int[] redsArr = { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
//                    Console.Clear();
//                    Console.WriteLine("Do you wish to bet on red or black?");
//                    string redOrBlack = Console.ReadLine().ToLower();

//                    landedOn(ballLand);
//                    if (redOrBlack == "red")
//                    {
//                        for (int i = 0; i < redsArr.Length; i++)
//                        {
//                            if (ballLand == redsArr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 1);
//                                win = true;
//                                break;
//                            }
//                        }
//                        //TODO: figure out way to show if player won that they're going to play again
//                        sorry();
//                    }
//                    else if (redOrBlack == "black")
//                    {
//                        landedOn(ballLand);
//                        for (int i = 0; i < blacksArr.Length; i++)
//                        {
//                            if (ballLand == blacksArr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 1);
//                                win = true;
//                                break;
//                            }
//                        }
//                        //TODO: figure out way to show if player won that they're going to play again
//                        sorry();
//                    }
//                    else
//                    {
//                        //TODO:Recursively ask again
//                    }
//                    playAgain(win, bet);
//                    break;
//                case 4:
//                    //Lows/High
//                    //TODO: Change lows and highs to correct lows and highs
//                    int[] lowsArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
//                    int[] highsArr = { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
//                    Console.Clear();
//                    Console.WriteLine("Do you wish to bet on low or high numbers?");
//                    string lowOrHighAnswer = Console.ReadLine().ToLower();
//                    landedOn(ballLand);
//                    if (lowOrHighAnswer == "low")
//                    {
//                        for (int i = 0; i < lowsArr.Length; i++)
//                        {
//                            if (ballLand == lowsArr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 1);
//                                win = true;
//                                break;
//                            }
//                        }
//                        //TODO: figure out way to show if player won that they're going to play again
//                        sorry();
//                    }
//                    else if (lowOrHighAnswer == "high")
//                    {
//                        for (int i = 0; i < highsArr.Length; i++)
//                        {
//                            if (ballLand == highsArr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 1);
//                                win = true;
//                                break;
//                            }
//                        }
//                    }
//                    else
//                    {
//                        //TODO:Recursively ask again
//                    }
//                    playAgain(win, bet);
//                    break;
//                case 5:
//                    //Dozens
//                    //TODO: Change row thirds with correct numbers

//                    int[] rowThirds1Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
//                    int[] rowThirds2Arr = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
//                    int[] rowThirds3Arr = { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
//                    Console.Clear();
//                    Console.WriteLine("Do you wish to bet on top(1-12), middle(13-24), or bottom dozens(25-36)?");
//                    string topMiddleBottom = Console.ReadLine().ToLower();
//                    if (topMiddleBottom == "top")
//                    {
//                        landedOn(ballLand);
//                        for (int i = 0; i < rowThirds1Arr.Length; i++)
//                        {
//                            if (ballLand == rowThirds1Arr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 2);
//                                win = true;
//                                break;
//                            }
//                        }
//                        //TODO: figure out way to show if player won that they're going to play again
//                        sorry();
//                    }
//                    else if (topMiddleBottom == "middle")
//                    {
//                        landedOn(ballLand);
//                        for (int i = 0; i < rowThirds2Arr.Length; i++)
//                        {
//                            if (ballLand == rowThirds2Arr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 2);
//                                win = true;
//                                break;
//                            }
//                        }
//                    }
//                    else if (topMiddleBottom == "bottom")
//                    {
//                        landedOn(ballLand);
//                        for (int i = 0; i < rowThirds3Arr.Length; i++)
//                        {
//                            if (ballLand == rowThirds3Arr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 2);
//                                win = true;
//                                break;
//                            }
//                        }
//                    }
//                    else
//                    {
//                        //TODO:Recursively ask again
//                    }
//                    playAgain(win, bet);
//                    break;
//                case 6:
//                    //Colummns
//                    //TODO: Change columns with correct numbers
//                    //TODO: Change for loops and if statements to match
//                    int[] column1Arr = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
//                    int[] column2Arr = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
//                    int[] column3Arr = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
//                    Console.Clear();
//                    Console.WriteLine("Do you wish to bet on 1st, 2nd, or 3rd column?\nEnter 1st 2nd or 3rd");
//                    string leftMiddleRightAnswer = Console.ReadLine().ToLower();
//                    landedOn(ballLand);
//                    if (leftMiddleRightAnswer == "1st")
//                    {
//                        for (int i = 0; i < column1Arr.Length; i++)
//                        {
//                            if (ballLand == column1Arr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 2);
//                                win = true;
//                                break;
//                            }
//                        }
//                        //TODO: figure out way to show if player won that they're going to play again
//                        sorry();
//                    }
//                    else if (leftMiddleRightAnswer == "2nd")
//                    {
//                        for (int i = 0; i < column2Arr.Length; i++)
//                        {
//                            if (ballLand == column2Arr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 2);
//                                win = true;
//                                break;
//                            }
//                        }
//                    }
//                    else if (leftMiddleRightAnswer == "3rd")
//                    {
//                        for (int i = 0; i < column3Arr.Length; i++)
//                        {
//                            if (ballLand == column3Arr[i])
//                            {
//                                bet = youWin(bet: bet, howMuch: 2);
//                                win = true;
//                                break;
//                            }
//                        }
//                    }
//                    else
//                    {
//                        //TODO:Recursively ask again if invalid entry
//                    }
//                    landedOn(ballLand);
//                    playAgain(win, bet);
//                    break;
//                case 7:
//                    //Street-Rows
//                    //(COMPLETE)TODO: implement correct number of streets
//                    //(COMPLETE)TODO: Change win payouts
//                    //TODO: Add try catch blocks
//                    Console.Clear();
//                    Console.WriteLine("Which street row do you wish to bet on? 1-12");
//                    int streetRowAnswer = Convert.ToInt32(Console.ReadLine());
//                    landedOn(ballLand);
//                    switch (streetRowAnswer)
//                    {
//                        case 1:
//                            if (ballLand == 1 || ballLand == 2 || ballLand == 3)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 2:
//                            if (ballLand == 4 || ballLand == 5 || ballLand == 6)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 3:
//                            if (ballLand == 7 || ballLand == 8 || ballLand == 9)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 4:
//                            if (ballLand == 10 || ballLand == 11 || ballLand == 12)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 5:
//                            if (ballLand == 13 || ballLand == 14 || ballLand == 15)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 6:
//                            if (ballLand == 16 || ballLand == 17 || ballLand == 18)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 7:
//                            if (ballLand == 19 || ballLand == 20 || ballLand == 21)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 8:
//                            if (ballLand == 22 || ballLand == 23 || ballLand == 24)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 9:
//                            if (ballLand == 25 || ballLand == 26 || ballLand == 27)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 10:
//                            if (ballLand == 28 || ballLand == 29 || ballLand == 30)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 11:
//                            if (ballLand == 31 || ballLand == 32 || ballLand == 33)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 12:
//                            if (ballLand == 34 || ballLand == 35 || ballLand == 36)
//                            {
//                                bet = youWin(bet: bet, howMuch: 11);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;

//                        default: //TODO: Call method recursively
//                            break;
//                    }
//                    playAgain(win, bet);
//                    break;
//                case 8:
//                    //6 numbers
//                    //TODO: Change DOUBLE streets with correct numbers
//                    //TODO: implement correct number of streets
//                    //TODO: Add for loops for additional steets
//                    //(COMPLETE)TODO: Change win payouts
//                    //TODO: change if statements and loops to match
//                    Console.Clear();
//                    Console.WriteLine("Which 6 numbers do you wish to bid on? Choose 1-11");
//                    int sixLineAnswer = Convert.ToInt32(Console.ReadLine());
//                    landedOn(ballLand);
//                    switch (sixLineAnswer)
//                    {
//                        case 1:
//                            if (ballLand == 1 || ballLand == 2 || ballLand == 3 || ballLand == 4 || ballLand == 5 || ballLand == 6)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 2:
//                            if (ballLand == 4 || ballLand == 5 || ballLand == 6 || ballLand == 7 || ballLand == 8 || ballLand == 9)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 3:
//                            if (ballLand == 7 || ballLand == 8 || ballLand == 9 || ballLand == 10 || ballLand == 11 || ballLand == 12)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 4:
//                            if (ballLand == 10 || ballLand == 11 || ballLand == 12 || ballLand == 13 || ballLand == 14 || ballLand == 15)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 5:
//                            if (ballLand == 13 || ballLand == 14 || ballLand == 15 || ballLand == 16 || ballLand == 17 || ballLand == 18)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 6:
//                            if (ballLand == 16 || ballLand == 17 || ballLand == 18 || ballLand == 19 || ballLand == 20 || ballLand == 21)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 7:
//                            if (ballLand == 19 || ballLand == 20 || ballLand == 21 || ballLand == 22 || ballLand == 23 || ballLand == 24)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 8:
//                            if (ballLand == 22 || ballLand == 23 || ballLand == 24 || ballLand == 25 || ballLand == 26 || ballLand == 27)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 9:
//                            if (ballLand == 25 || ballLand == 26 || ballLand == 27 || ballLand == 28 || ballLand == 29 || ballLand == 30)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 10:
//                            if (ballLand == 28 || ballLand == 29 || ballLand == 30 || ballLand == 31 || ballLand == 32 || ballLand == 33)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        case 11:
//                            if (ballLand == 31 || ballLand == 32 || ballLand == 33 || ballLand == 34 || ballLand == 35 || ballLand == 36)
//                            {
//                                bet = youWin(bet: bet, howMuch: 5);
//                                win = true;
//                            }
//                            else
//                            {
//                                sorry();
//                            }
//                            break;
//                        default://TODO: recursively call again
//                            break;
//                    }
//                    playAgain(win, bet);
//                    break;
//                case 9:
//                    //Split
//                    //TODO: Implement splits 
//                    //TODO: Add logic that does not allow user to enter two numbers not adjacent
//                    //TODO: Add try catch for conversion from the console
//                    //TODO: change payout amount
//                    Console.Clear();
//                    Console.WriteLine("Choose first number");
//                    int firstNumberAnswer = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Choose second adjacent number");
//                    int secondNumberAnswer = Convert.ToInt32(Console.ReadLine());
//                    landedOn(ballLand);
//                    if (ballLand == firstNumberAnswer || ballLand == secondNumberAnswer)
//                    {
//                        bet = youWin(bet: bet, howMuch: 17);
//                        win = true;
//                    }
//                    else sorry();
//                    playAgain(win, bet);
//                    break;
//                case 10:
//                    //Corners
//                    //TODO: Implement corners
//                    //TODO: Add logic that does not allow user to enter two numbers not adjacent
//                    //TODO: Add try catch for conversion from the console
//                    //(Complete)TODO: change payout amount
//                    Console.Clear();
//                    Console.WriteLine("Choose first number");
//                    int firstCornerAnswer = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Choose second corner number");
//                    int secondCornerAnswer = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Choose third corner number");
//                    int thirdCornerAnswer = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Choose fourth corner number");
//                    int fourthCornerAnswer = Convert.ToInt32(Console.ReadLine());
//                    landedOn(ballLand);
//                    if (ballLand == firstCornerAnswer || ballLand == secondCornerAnswer || ballLand == thirdCornerAnswer || ballLand == fourthCornerAnswer)
//                    {
//                        bet = youWin(bet: bet, howMuch: 8);
//                        win = true;
//                    }
//                    else sorry();
//                    playAgain(win, bet);
//                    break;
//                default:
//                    Console.Clear();
//                    Console.WriteLine("PLEASE TRY AGAIN WITH VALID CHOICE\n");
//                    typeBet(bet);
//                    break;
//            }

//        }

//        public void Outcome(IPlayer player)
//        {
//            throw new NotImplementedException();
//        }

//        public void NextRoute(IPlayer player)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
