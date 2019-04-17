using System;
using static GameOfRoulette.Welcome;

namespace GameOfRoulette
// The goal is to make an unbreakable&intuitive Casino!
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changes colors of the console
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.Clear(); // Essentially refreshing the whole console dying it red
            Console.ForegroundColor = ConsoleColor.Red;

            //Beginning of the night!
            //How much are we taking out of the ATM?
            YourNightsGamble();

            

        }
    }
}
