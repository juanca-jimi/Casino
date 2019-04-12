using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfRoulette
{
    class EnterPlayer
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome to our roulette table\n" +
                "How much money do you wish to gamble?");
            try
            {
                //This will set the property in the YourPot Class
                YourPot originalPot = new YourPot();
                originalPot.Bet = Int32.Parse(Console.ReadLine());
                typeBet(originalPot.Bet);
            }
            catch (Exception)
            {
                //If the user does not give an integer then the method will recursively run
                Console.WriteLine("Please enter valid number\n");
                welcome();
            }
        }
    }
}
