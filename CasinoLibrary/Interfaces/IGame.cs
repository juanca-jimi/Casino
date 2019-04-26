namespace CasinoLibrary
{
    public interface IGame
    {
        //intended to be displayed to the user when deciding what game to play
        string DisplayName { get; }

        //property win-true
        bool Win { get; set; }

        //How much did we make?
        double WinMultiplier { get; set; }

        //Betting system
        //When determining initial bet in the game
        //we have to display the current amount so that they know how much they have to bet 
        void DetermineInitialBet(IPlayer player);

        //Play
        void Play(IPlayer player);

        //Outcome
        void Outcome(IPlayer player);
    }
}
