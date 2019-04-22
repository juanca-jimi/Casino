using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLibrary
{
    public class Player : IPlayer
    {

        public string PlayerName { get; set; }

        public int TotalMoney { get; set; }

        public int CurrentBet { get; set; }
    }
}
