namespace Squer.Workshops.MutationTesting.Production
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
    }
}

