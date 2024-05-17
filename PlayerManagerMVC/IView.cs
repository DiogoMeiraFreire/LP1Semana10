using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public interface IView
    {
        int MainMenu();

        void EndMassage();

        void InvalidOption();

        void AfterMenu();

        Player InsertPlayer();

        void ListPlayers(List<Player> players);

        int AskForMinimumScore();

        void ListPlayersWithScoreGreaterThan(List<Player> players, int score);
        
    }
}