using System;
using CasinoLibrary;

namespace GameOfRoulette
{
    public class EnterPlayer
    {
        //TODO: Handle case for decimals 
        public static void YourNightsGamble(IPlayerModel playerModel) 
        {

            Console.WriteLine($"{playerModel.PlayerName}, welcome to our roulette table\n" +
                "How much money do you wish to gamble tonight?");

            //Grabs our total amount of money from the ATM!

            try
            {
                int AllOurMoney = checked(Int32.Parse(Console.ReadLine()));

                //Greater than zero
                if (AllOurMoney < 1 )
                {
                    throw new ArgumentOutOfRangeException();
                }

                //If meets our criteria
                //Save this to our Pot object
                playerModel.TotalMoney = AllOurMoney;
            }

            catch (OverflowException)
            {
                Console.Clear();

                //if our checked throws an exception
                Console.WriteLine("\tThat's too much money! You might take the house down.\n" +
                    "Please enter a lower number");

                //recursion
                YourNightsGamble(playerModel);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();

                //has to be greater than zero
                Console.WriteLine("Please enter a positive number");

                //recursion
                YourNightsGamble(playerModel);
            }
            catch (Exception)
            {
                Console.Clear();

                //If the user does not give an integer then the method will recursively run
                Console.WriteLine("Please enter valid number\n");
                
                //recursion
                YourNightsGamble(playerModel);
            }


            Console.WriteLine($"Great {playerModel.PlayerName}, " +
                $"we've taken {playerModel.TotalMoney:C} out of the ATM!");
            Console.ReadKey();
        }
    }
}
