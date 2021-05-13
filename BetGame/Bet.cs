using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetGame
{
    /// <summary>
    /// Bet class representing Bet Amount as well as Plane on Bet is placed.
    /// </summary>
    public class Bet
    {
        // Bet amount
        public int Amount { get; set; }

        // Plane reference on Bet is Placed
        public Plane Plane { get; set; }
    }
}
