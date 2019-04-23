using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLibrary
{
    public interface IGame
    {
        //Betting system
        void DetermineInitialBet(IPlayer player);


        //Outcome
        void Outcome(IPlayer player);


        //Evaluate win or lose
        bool Win { get; set; }


        //Keep playing?
        void NextRoute(IPlayer player);
    }
}
