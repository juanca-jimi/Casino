using System;
using CasinoLibrary;

namespace CasinoUI
{
    public static class GenerateGameEx
    {
        //TODO: Inject Dependencies once project is organized into working solution
        public static IPlayer CreatePlayer()
        {
            Console.WriteLine("What's your name tonight?");
            String playersName = Console.ReadLine();
            Player guest = new Player() { PlayerName = playersName };

            //Each player comes with their own log of their night
            //TODO: Dependency Inject this
            ILogger ThisPlayerLog = CreateNewLog(guest);

            return guest;
        }
        public static ILogger CreateNewLog(IPlayer player)
        {
            return new Logger(player);
        }
        public static IGame CreateNewGame(IGame game)
        {
            //TODO: Implement this overload

            //TODO:Change this return
            return game;
        }
        public static IGame CreateNewGame(string GameChoice)
        {
            //Allowing me to return my game of choice

            //Initializing it in scope so that we can return it 
            IGame game;

            try
            {

                throw new NotSupportedException();
            }
            catch (NotSupportedException)
            {

                
            }

            return game;
        }
    }
}
