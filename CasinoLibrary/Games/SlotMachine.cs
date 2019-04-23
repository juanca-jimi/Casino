using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLibrary
{
    public class SlotMachine : IGame
    {
        public bool Win { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DetermineInitialBet(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void NextRoute(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void Outcome(IPlayer player)
        {
            throw new NotImplementedException();
        }

    }
}
