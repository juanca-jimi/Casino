﻿using System;
using CasinoLibrary;
using static GameOfRoulette.EnterPlayer;

//TODO: Change this from Gameof... to CasinoUI
//... And not get build errors. 
//Previously attempted 

namespace GameOfRoulette
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

    }
}
