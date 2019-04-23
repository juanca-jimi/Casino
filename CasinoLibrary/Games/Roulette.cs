﻿using CasinoLibrary;
using System;

namespace GameOfRoulette
{
    public class Roulette : IGame
    {
        public void DetermineInitialBet(IPlayer player)
        {
            Console.WriteLine("How much our we gambling on this?");

            //Implement Exception Handling
            try
            {
                 player.CurrentBet = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void typeBet(IPlayer player)
        {

            Console.WriteLine($"\tYou're betting {player.CurrentBet:c}\t\n\tHow do you wish to play it?\n");
            Console.WriteLine("1. Numbers: the number of the bin\n" +
                                "2.Evens / Odds: even or odd numbers\n" +
                                "3.Reds / Blacks: red or black colored numbers\n" +
                                "4.Lows / Highs: low(1 – 18) or high(19 – 38) numbers\n" +
                                "5.Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36\n" +
                                "6.Columns: ﬁrst, second, or third columns\n" +
                                "7.Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24\n" +
                                "8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26\n" +
                                "9.Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36\n" +
                                "10.Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 /");

            try
            {
                player.CurrentBet = Convert.ToInt32(Console.ReadLine());
                outcome(player.CurrentBet, bet);
            }

            catch (Exception)
            {
                Console.Clear();
                //Will call method recursively if entry is not integer
                Console.WriteLine("Please enter a valid bet\n");
                typeBet(bet);
            }
        }

    }
}