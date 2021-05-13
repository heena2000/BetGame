using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetGame
{
    /// <summary>
    /// This class is a Factory for Player class object
    /// </summary>
    public class GameFactory
    {
        /// <summary>
        /// This Factory method is used to generate Player Object according to given Player Number
        /// </summary>
        /// <param name="playerNumber">Player Number</param>
        /// <returns>Player Object if valid number given</returns>
        public static Player GetPlayer(int playerNumber)
        {
            if (playerNumber == 1)
            {
                return new Player1();
            }
            else if (playerNumber == 2)
            {
                return new Player2();
            }
            else if (playerNumber == 3)
            {
                return new Player3();
            }
            return null;
        }
    }
}
