using System;

namespace CasinoLibrary
{
    public class LetsGamble
    {
        public IPlayer player { get; set; }
        public IGame game { get; set; }

        public LetsGamble(IPlayer player, string game)
        {

        }

        //TODO: Determine whether you have to pass the Player as a parameter or
        //      Or if the "this" keyword will be sufficient with planned logic
        void youWin(double WinMultiplier)
        {
            Console.WriteLine(
                $"You won {(this.player.CurrentBet * WinMultiplier):C}!!!" +
                $"\n\tYour your pot is now " +
                $"{(WinMultiplier * this.player.CurrentBet + this.player.CurrentBet):C}\n");

            //Rounding to the nearest integer and adding to our total pot
            player.TotalMoney += (int)(WinMultiplier * this.player.CurrentBet + this.player.CurrentBet);

            Console.WriteLine($"Your new total amount of money is {player.TotalMoney:c}");
        }


        public static void DetermineRoute(IPlayer player)
        {
            //First thing we're checking 
            //Does the player have money to keep playing?
            if (player.TotalMoney == 0)
            {
                Console.Clear();
                sorry();
            }
            else if (PlayingAgain())
            {

            }
            else
            {
                //Return to lobby to play another game
            }
        }

        private static bool playAgain()
        {
            if (win)
            {

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


            return true;
        }

        //Showing what the player currently has in his account
        public void PlayersTotalMoney()
        {
            Console.WriteLine($"You currently have {player.TotalMoney:C} left to play with");
        }


        private static void sorry()
        {
            Console.WriteLine("You have no money tonight... Better luck next time!\n\tThanks for coming to the Casino!\n\n");
            //Display log of the night
            Console.ReadKey();
        }
    }
}
