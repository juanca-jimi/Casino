using CasinoLibrary;
using System;

namespace GameOfRoulette
{
    public static class GenerateGameEx
    {
        public static IPlayerModel CreatePlayer()
        {
            Console.WriteLine("What's your name tonight MoneyBags?");
            String playersName = Console.ReadLine();
            return new PlayerModel() { PlayerName = playersName}; 
        }
    }
}
