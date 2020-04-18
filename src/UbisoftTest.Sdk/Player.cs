using System;
using System.Collections.Generic;

namespace UbisoftTest.Sdk
{
    public class Player
    {
        public int Playerid { get; set; }
        public String PlayerName { get; set; }
        public List<Match> Matches { get; set; }
    }
}
