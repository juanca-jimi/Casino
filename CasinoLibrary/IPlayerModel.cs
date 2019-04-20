namespace CasinoLibrary
{
    public interface IPlayerModel
    {
        int CurrentBet { get; set; }
        string PlayerName { get; set; }
        int TotalMoney { get; set; }
    }
}