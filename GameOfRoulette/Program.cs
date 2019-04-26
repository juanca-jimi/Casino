using System;
using CasinoLibrary;
using static CasinoUI.EnterPlayer;

//TODO: Change this from Gameof... to CasinoUI
//... And not get build errors. 
//Previously attempted 

namespace CasinoUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CasinoColoring();

            //Beginning of the night!
            //Whats your name?
            IPlayer CasinoGuest = GenerateGameEx.CreatePlayer();

            //How much are we taking out of the ATM?
            YourNightsGamble(CasinoGuest);
            
        }

        static void CasinoColoring()
        {
            //Commented because hard to see these colors on screen

            //Changes colors of the console
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.Clear(); // Essentially refreshing the whole console dying it our chosen color

            Console.ForegroundColor = ConsoleColor.Red;
        }

    }
}
