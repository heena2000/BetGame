using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGame
{
    public partial class Form1 : Form
    {
        // represent all planes 
        private Plane[] planes;

        // represent all players
        private Player[] players;

        // represent all Timer for movement of pictures
        private Timer[] timers;

        // represent Winner Plane
        Plane winner;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGameComponents();
        }

        /// <summary>
        /// Initialize All Game Comonents
        /// </summary>
        private void InitializeGameComponents()
        {
            // Hold All picture box reference to an Array
            PictureBox[] pictures = { picture1, picture2, picture3, picture4 };
            
            // Initialize the planes array
            planes = new Plane[pictures.Length];
            // Prepare Plane Object for storing details of Plane
            for(int index = 0; index < planes.Length; index++)
            {
                planes[index] = new Plane();
                planes[index].Name = "Plane " + (index + 1);
                planes[index].Picture = pictures[index];
                planes[index].TrackLength = 710;
            }

            // Hold All Text Box reference to an Arrays
            TextBox[] textBoxes = { text1, text2, text3 };
            // Hold All Radio Button reference to an Arrays
            RadioButton[] radioButtons = { radio1, radio2, radio3 };

            // Initialize the players array
            players = new Player[textBoxes.Length];
            for( int index = 0; index < players.Length; index++)
            {
                players[index] = GameFactory.GetPlayer(index + 1);
                players[index].RadioButton = radioButtons[index];
                players[index].TextBox = textBoxes[index];
                players[index].Amount = 50;
                players[index].RadioButton.Text = players[index].Name;
            }

            // Set the Number for Plane
            numericPlaneNo.Minimum = 1;
            numericPlaneNo.Maximum = planes.Length;
            numericPlaneNo.Value = 1;

            // Disable the Begin Race Button...
            btnBegin.Enabled = false;
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            SetupPlayerDetails();
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            SetupPlayerDetails();
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            SetupPlayerDetails();
        }

        /// <summary>
        /// Setup Player Details of Bet     
        /// </summary>
        private void SetupPlayerDetails()
        {
            // Iterate All Player holded by players Arary
            for(int index = 0; index < players.Length; index++)
            {
                Player player = players[index];
                // Assure Player has no Amount available
                if(player.NoAmountStatus)
                {
                    player.TextBox.Text = "Player Lost all Amount So BUSTED";
                }
                else
                {
                    // player Placed a Bet or Not
                    if(player.Bet == null )
                    {
                        player.TextBox.Text = string.Format("{0} hasn't placed a Bet", player.Name);
                    }
                    else
                    {
                        player.TextBox.Text = string.Format("{0} placed Bet Amount ${1} on {2}", player.Name, player.Bet.Amount, player.Bet.Plane.Name);
                    }
                    // Is Player Radio Button is Checked or Not
                    if(player.RadioButton.Checked)
                    {
                        // Set All Control value according to selected Player
                        lblMax.Text = string.Format("{0} Max Bet Amount Limit is ${1}", player.Name, player.Amount);
                        btnPlace.Text = string.Format("Place A BET For Player {0}", player.Name);
                        lblBet.Text = string.Format("Bet Amount of {0} is $", player.Name);
                        lblPlaneSelection.Text = string.Format("{0} Place Bet on Plane No", player.Name);
                        numericBetAmount.Minimum = 1;
                        numericBetAmount.Maximum = player.Amount;
                        numericBetAmount.Value = 1;
                    }
                }
            }
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            int active_player = 0;
            int bet_count = 0;
            // Traverse all Player in players Array
            for(int index = 0; index < players.Length; index++)
            {
                // Check  Player is Still in Game or it has money for Bet
                if( !players[index].NoAmountStatus)
                {
                    active_player++;
                    // Check Currently Player Radio Button is Selected
                    if( players[index].RadioButton.Checked)
                    {
                        string message = "";
                        // Check Player Already place a bet or  not
                        if( players[index].Bet != null )
                        {
                            message = string.Format(" {0} is Already Placed Bet For Race Game...", players[index].Name);
                        }
                        else
                        {
                            // Capture value of Bet Amount and Plane No
                            int plane_no = (int)numericPlaneNo.Value;
                            int bet_amount = (int)numericBetAmount.Value;

                            // Check Current Plane No is Already pick by other player
                            bool picked = false;
                            for(int i = 0; i < players.Length; i++)
                            {
                                // Check Player Bet on Plane
                                if (players[i].Bet != null && players[i].Bet.Plane == planes[plane_no - 1])
                                {
                                    picked = true;
                                    break;
                                }
                            }
                            if(picked)
                            {
                                message = string.Format("Plane No {0} is Picked By Another Player", plane_no);
                            }
                            else
                            {
                                Bet bet = new Bet();
                                bet.Amount = bet_amount;
                                bet.Plane = planes[plane_no - 1];
                                players[index].Bet = bet;
                            }
                        }
                        // If there is any message to display
                        if(message.Length!=0)
                        {
                            MessageBox.Show(message);
                        }                        
                    }
                    
                    if(players[index].Bet!=null)
                    {
                        bet_count++;
                    }
                }
            }
            SetupPlayerDetails();
            if(bet_count == active_player)
            {
                btnPlace.Enabled = false;
                btnBegin.Enabled = true;
                panelGame.Enabled = false;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            timers = new Timer[planes.Length];
            for( int index = 0; index < timers.Length; index++)
            {
                timers[index] = new Timer();
                timers[index].Interval = 16;
                timers[index].Tick += Timer_Tick;
            }
            foreach(Timer timer in timers)
            {
                timer.Start();
            }
            btnBegin.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Event Sender is Timer 
            if(sender is Timer)
            {
                Timer timer = (Timer)sender;
                int index = -1;
                for(int i = 0; i < timers.Length; i++)
                {
                    if(timer == timers[i])
                    {
                        index = i;
                        break;
                    }
                }
                if(index != -1)
                {
                    PictureBox picture = planes[index].Picture;
                    if (picture.Location.X + picture.Width > planes[index].TrackLength)
                    {
                        if (winner == null)
                        {
                            winner = planes[index];
                        }
                        foreach(Timer tim in timers)
                        {
                            tim.Stop();
                        }
                    }
                    else
                    {
                        int step = new Random().Next(1, 25);
                        picture.Location = new Point(picture.Location.X + step, picture.Location.Y);
                    }
                }
            }
        
            // Check is There any Winner
            if(winner != null )
            {
                MessageBox.Show(string.Format("{0} is won the Race!!!", winner.Name));
                SetupPlayerDetails();
                // Update The Winner Status of Player
                for(int index = 0; index < players.Length; index++)
                {
                    // Check Player is involved in Betting
                    if( players[index].Bet != null )
                    {
                        int amount = players[index].Bet.Amount;
                        // Check Player Scooter win
                        if(players[index].Bet.Plane == winner)
                        {
                            players[index].Amount += amount;
                            players[index].TextBox.Text = string.Format("{0} won the Race and Now, has ${1} Amount in Hand", players[index].Name, players[index].Amount);
                            players[index].WinningStatus = true;
                        }
                        else
                        {
                            players[index].Amount -= amount;
                            if(players[index].Amount == 0 )
                            {
                                players[index].TextBox.Text = "Player Lost all Amount So BUSTED";
                                players[index].NoAmountStatus = true;
                                players[index].RadioButton.Enabled = false;
                            }
                            else
                            {
                                players[index].TextBox.Text = string.Format("{0} Lost ${1} Amount in the Race and Now, has ${1} Amount in Hand", players[index].Name,amount, players[index].Amount);
                            }
                        }
                    }
                }

                // Reset the Game components
                winner = null;
                timers = null;
                int inactive_count = 0;
                for (int index = 0; index < players.Length; index++)
                {
                    // Check Player have Amount Left for bet
                    if (players[index].NoAmountStatus)
                    {
                        inactive_count++;
                    }
                    else
                    { 
                        // Check Radio of Player is Selected or Not
                        RadioButton radioButton = players[index].RadioButton;
                        if (radioButton.Enabled && radioButton.Checked)
                        {
                            lblMax.Text = string.Format("{0} Max Bet Amount Limit is ${1}", players[index].Name, players[index].Amount);
                            btnPlace.Text = string.Format("Place A BET For Player {0}", players[index].Name);
                            lblBet.Text = string.Format("Bet Amount of {0} is $", players[index].Name);
                            lblPlaneSelection.Text = string.Format("{0} Place Bet on Plane No", players[index].Name);
                            numericBetAmount.Maximum = players[index].Amount;
                            numericBetAmount.Minimum = 1;
                        }
                    }
                    players[index].Bet = null;
                    players[index].WinningStatus = false;
                }
                // Check All Player are Busted
                if(inactive_count == players.Length)
                {
                    MessageBox.Show("GAME OVER!!!!");
                    Application.Exit();
                }
                else // Enable the Game for Restart
                {
                    panelGame.Enabled = true;
                    btnPlace.Enabled = true;
                    MessageBox.Show("You Can Player For Game with Bet...");
                    SetupPlayerDetails();
                }
                // Reset the Plane Picture at Original Position
                for(int index = 0; index < planes.Length; index++)
                {
                    PictureBox picture = planes[index].Picture;
                    picture.Location = new Point(2, picture.Location.Y);
                }
            }
        }
    }
}
