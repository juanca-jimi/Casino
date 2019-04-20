//using System;
//using static GameOfRoulette.PlayRoulette;

//namespace GameOfRoulette
//{
//    public class KeepPlaying
//    {
//        public static void DetermineRoute()
//        {
//            if ()
//            {

//            }
//            else 
//            {
//                Console.WriteLine("Do you wish to push your luck? y/n");
//                playAgain();
//            }
//        }
//        private static void sorry()
//        {
//            {
//                Console.WriteLine("Better luck next time!\n\tThanks for coming to the Casino!");
//                Console.ReadKey();
//            }
//        }
//        private static void playAgain(bool win, int bet)
//        {
//            if (win)
//            {
                
//                try
//                {
//                    char play = Convert.ToChar(Console.ReadLine().ToLower());
//                    if (play == 'y')
//                    {
//                        typeBet(bet: bet);
//                    }
//                    else
//                    {
//                        Console.Clear();
//                        Console.WriteLine($"Thanks for playing, you take home {bet:c}");
//                        Console.ReadKey();
//                    }
//                }
//                catch
//                {
//                    Console.Clear();
//                    Console.WriteLine("Please enter \"y\" or \"n\"\n");
//                    playAgain(win, bet);
//                }
//            }
//        }
//    }
//}

