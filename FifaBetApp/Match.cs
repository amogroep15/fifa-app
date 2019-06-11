using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaBetApp
{
    class Match
    {
        public string team1 { get; set; }
        public string team2 { get; set; }

        public Match(string team1, string team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        public override string ToString()
        {
            return team1 + " vs " + team2;
        }
    }
}
