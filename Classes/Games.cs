using System;

namespace HHPool.App.Classes
{
    public class Games
    {
        public int gamePK { get; set; }
        public string link { get; set; }
        public string gameType { get; set; }
        public string season { get; set; }
        public DateTime gameDate { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Venue venue { get; set; }
        public Content content { get; set; }


    }
}
