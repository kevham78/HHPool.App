using System;
using System.Collections.Generic;

namespace HHPool.App.Classes
{
    public class Dates
    {
        public DateTime date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public List<Games> games { get; set; }

    }
}