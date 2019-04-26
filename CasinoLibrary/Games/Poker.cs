using System;
using System.Reflection;

namespace CasinoLibrary.Games
{
    class Poker : IGame
    {
        

        public bool Win { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string DisplayName => "Poker";

        public double WinMultiplier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DetermineInitialBet(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void Outcome(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void Play(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
