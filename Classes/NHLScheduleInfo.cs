using HHPool.App.Classes;
using System.Collections.Generic;

namespace HHPool.App
{
    public class NHLSchedule
    {
        public string copyright { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public MetaData metaData { get; set; }
        public int wait { get; set; }
        public List<Dates> Dates { get; set; }

    }

}