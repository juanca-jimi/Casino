using System;
using CasinoLibrary;
using static CasinoUI.GenerateGameEx;
using static CasinoUI.EnterPlayer;
 

namespace CasinoUI
{
    public class LetsGamble
    {
        public IPlayer player { get; set; }
        public IGame game { get; set; }

        public LetsGamble(IPlayer thisPlayer, string thisGame)
        {
            player = thisPlayer;

            //Matching the string to the game
            //TODO: Catch exception somewhere in the program if this happen
            this.game = CreateNewGame(thisGame);

        }

        //TODO: Determine whether you have to pass the Player as a parameter or
        //      Or if the "this" keyword will be sufficient with planned logic
        void youWin(double WinMultiplier)
        {
            //Rounding to the nearest integer and adding to our total pot
            player.TotalMoney += (int)(WinMultiplier * this.player.CurrentBet + this.player.CurrentBet);

            Console.WriteLine(
                $"You won {(this.player.CurrentBet * WinMultiplier):C}!!!" +

                $"\n\tYour your pot is now " +

                //Win amount is already calculated into the total money
                $"{player.TotalMoney:C}\n");


            Console.WriteLine($"Your new total amount of money is {player.TotalMoney:c}");
        }


        void DetermineRoute(IPlayer player)
        {
            //First thing we're checking 
            //Does the player have money to keep playing?
            //If true will not step into other cases and step you out of the Casino

            //Bouncer shows up
            if (player.TotalMoney == 0)
            {
                Console.Clear();
                sorry();
            }

            //Create new instance of this game
            else if (PlayingSameGame())
            {
                CreateNewGame(this.game);
            }

            else
            {
                //Default is to send player to lobby
                TheLobby(this.player);
            }

        }

        //Private - Only being used in this class
        private static bool PlayingSameGame()
        {

            try
            {
                //char is the smallest intuitive datatype to save memory
                char choice = Convert.ToChar(Console.ReadLine().ToLower());

                //play again
                if (choice == 'y')
                {
                    return true;
                }

                //Dont play again
                else if (choice == 'n')
                {
                    return false;
                }

                //does not meet our range of answers
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Please enter \"y\" or \"n\"\n");

                //Recursively call method
                //TODO:test to ensure stack overflow exception does not occur
                PlayingSameGame();
            }

            //returning false by default
            //once user in the lobby they can go back to the same game if they want
            //although the method should not reach this point
            return false;
        }

        //Showing what the player currently has in his account
        public void PlayersTotalMoney()
        {
            Console.WriteLine($"You currently have {player.TotalMoney:C} left to play with");
        }


        private static void sorry()
        {
            Console.WriteLine("You have no money tonight... Better luck next time!\n\tThanks for coming to the Casino!\n\n");
            //TODO: Display log/history of the night
            Console.ReadKey();
        }
    }
}
