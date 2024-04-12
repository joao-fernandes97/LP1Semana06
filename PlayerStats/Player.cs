using System;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        public float HighScore
        {
            get => highScore;
            set 
            { 
                if(value > highScore)
                    highScore = value;
            }
        }
        private int playedGames;
        private int wonGames;
        public string Name {get;}
        public float WinRate
        {
            get
            {
                if(playedGames>0)
                {
                    return playedGames/wonGames;
                }else
                {
                    return 0;
                }
            }
        }

        public Player(string name)
        {
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if(win) wonGames++;
        }
        
    }
}