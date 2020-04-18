using System;
using System.Collections.Generic;

namespace UbisoftTest.Sdk
{
    public class Match
    {
        public int Kill { get; set; }
        public int Score { get; set; }
        public DateTime Time { get; set; }
        public List<Player> Players { get; set; }
    }
}
