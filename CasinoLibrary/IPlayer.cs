namespace CasinoLibrary
{
    public interface IPlayer
    {
        int CurrentBet { get; set; }
        string PlayerName { get; set; }
        int TotalMoney { get; set; }
    }
}