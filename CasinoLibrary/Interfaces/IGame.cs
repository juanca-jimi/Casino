using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLibrary
{
    public interface IGame
    {
        //intended to be displayed to the user when deciding what game to play
        string DisplayName { get; }


        //Betting system
        //When determining initial bet in the game
        //we have to display the current amount so that they know how much they have to bet 
        void DetermineInitialBet(IPlayer player);

        //Play
        void Play(IPlayer player);

        //Outcome
        void Outcome(IPlayer player);


        //Evaluate win or lose
        bool Win { get; set; }

       
    }
}
