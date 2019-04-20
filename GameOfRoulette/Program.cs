using System;
using CasinoLibrary;
using static GameOfRoulette.EnterPlayer;
using static GameOfRoulette.GenerateGameEx;


namespace GameOfRoulette
{
    class Program
    {

        static void Main(string[] args)
        {
            //The goal is to make an unbreakable & intuitive Casino!

            //Changes colors of the console
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.Clear(); // Essentially refreshing the whole console dying it our chosen color

            Console.ForegroundColor = ConsoleColor.Red;

            //Beginning of the night!

            //Whats your name?
            IPlayerModel JimisGuest = CreatePlayer();

            //How much are we taking out of the ATM?
            YourNightsGamble(JimisGuest);

            //TODO: Log Beggining of the night


            

        }
    }
}
