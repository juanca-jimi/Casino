using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLibrary
{
    public class SlotMachine : IGame
    {
        public string DisplayName => "Slot Machine";

        public bool Win { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
