using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGame
{
    /// <summary>
    /// Parent of Player Class for sharing common details
    /// </summary>
    public abstract class Player
    {
        // Amount value of Player
        public int Amount { get; set; }

        // Current Bet reference done by Player
        public Bet Bet { get; set; }

        // Radio Button reference associate with Player object
        public RadioButton RadioButton { get; set; }

        // Name of Player
        public string Name { get; set; }

        // Current Game Winning status of Player
        public bool WinningStatus { get; set; }

        // Text Box reference associate with Player object
        public TextBox TextBox { get; set; }

        // Represent No Amount Status of Player
        public bool NoAmountStatus { get; set; }
    }
}
