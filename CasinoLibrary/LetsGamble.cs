using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLibrary
{
    public class LetsGamble
    {

        public LetsGamble(IPlayer player)
        {
            
        }

        public static void DetermineCurrentBet()
        {
            Console.WriteLine("How much our we gambling on this?");

            //Implement Exception Handling
            try
            {
                 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
