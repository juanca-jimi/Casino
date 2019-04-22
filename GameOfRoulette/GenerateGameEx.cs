using System;
using CasinoLibrary;

namespace GameOfRoulette
{
    public static class GenerateGameEx
    {
        //TODO: Inject Dependencies once project is organized into working solution
        public static IPlayer CreatePlayer()
        {
            Console.WriteLine("What's your name tonight?");
            String playersName = Console.ReadLine();
            return new Player() { PlayerName = playersName}; 
        }
    }
}
