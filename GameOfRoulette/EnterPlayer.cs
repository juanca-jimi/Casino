using System;
using System.Collections.Generic;
using System.Linq;
using CasinoLibrary;

namespace CasinoUI
{
    public class EnterPlayer
    {
        //Sets the total in the Player class
        //TODO: Handle case for decimals 
        public static void YourNightsGamble(IPlayer player) 
        {

            Console.WriteLine($"{player.PlayerName}, welcome to our roulette table\n" +
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
                player.TotalMoney = AllOurMoney;
            }

            catch (OverflowException)
            {
                Console.Clear();

                //if our checked throws an exception
                Console.WriteLine("\tThat's too much money! You might take the house down.\n" +
                    "Please enter a lower number");

                //recursion
                YourNightsGamble(player);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();

                //has to be greater than zero
                Console.WriteLine("Please enter a positive number");

                //recursion
                YourNightsGamble(player);
            }
            catch (Exception)
            {
                Console.Clear();

                //If the user does not give an integer then the method will recursively run
                Console.WriteLine("Please Try Again\n");
                
                //recursion
                YourNightsGamble(player);
            }


            Console.WriteLine($"Great {player.PlayerName}, " +
                $"we've taken {player.TotalMoney:C} out of the ATM!");

            Console.ReadKey();
        }
        public static void TheLobby(IPlayer player)
        {
            Console.WriteLine("We're at the lobby! What game do you want to play?");

            var Games = GetImplementationsOf<IGame>();

            //Displays names of games

            //TODO: Display the names of the games normally and not Camel Case 
            //Attempts that have failed: Creating a property in the interface
            //                           Declaring a new MemberInfo in the interface

            foreach (var Game in Games)
            {
                Console.WriteLine(Game.Name);
            }

            //Users input for the game path
            //TODO: Implement exception handling if path not a valid option
            string GameOfChoice = Console.ReadLine();
            
            //Checks if they selected a valid game
            foreach (var Game in Games)
            {
                if (GameOfChoice.Replace(" ","").ToLower() == Game.Name.Replace(" ", "").ToLower())
                {
                    
                }
            }

        }


        //Creates an Enumerable to iterate through all our games and see if 
        //Got help from stack overflow for this one
        //https://stackoverflow.com/questions/48716027/iterate-through-implementations-of-an-interface-and-invoke-a-method

        private static IEnumerable<Type> GetImplementationsOf<TInterface>()
        {
            var interfaceType = typeof(TInterface);
            return 
                AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Select(assembly => assembly.GetTypes().Where(type => !type.IsInterface && interfaceType.IsAssignableFrom(type)))
                .SelectMany(implementation => implementation);

        }
    }
}
