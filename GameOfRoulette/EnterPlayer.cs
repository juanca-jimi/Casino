using System;

namespace GameOfRoulette
{
    public class Welcome
    {
        //TODO: handle decimal-money case
        //TODO: Write unit test

        //This instantiates tonights pot with the PlayerPot Class
        public static PlayerPot TonightsPot = new PlayerPot();

        public string PlayerName { get; }

        public Welcome(string Name)
        {
            PlayerName = Name;
        }

        public static void YourNightsGamble()
        {

            Console.WriteLine($"Welcome to our roulette table\n" +
                "How much money do you wish to gamble tonight?");
            try
            {
                int AllOurMoney = checked(Int32.Parse(Console.ReadLine()));

                //Greater than zero
                if (AllOurMoney < 1 )
                {
                    throw new ArgumentOutOfRangeException();
                }

                //If meets our criteria
                //Save this to our Pot object
                TonightsPot.TotalBet = AllOurMoney;
            }

            catch (OverflowException)
            {
                Console.Clear();

                //if our checked throws an exception
                Console.WriteLine("\tThat's too much money! You might take the house down.\n" +
                    "Please enter a lower number");

                //recursion
                Welcome();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();

                //has to be greater than zero
                Console.WriteLine("Please enter a positive number");

                //recursion
                Welcome();
            }
            catch (Exception)
            {
                Console.Clear();

                //If the user does not give an integer then the method will recursively run
                Console.WriteLine("Please enter valid number\n");
                
                //recursion
                Welcome();
            }

            Console.WriteLine($"Great we're play with {TonightsPot.TotalBet:C}!");
        }
    }
}
