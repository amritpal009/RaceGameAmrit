using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGameAmrit
{
    public partial class Form1 : Form
    {
        Car[] Cars = new Car[4];

        PunterFactory pFactory = new PunterFactory();
        Punter[] punters = new Punter[3];
        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }
        private void SetupRaceTrack()
        {

            Car.StartPosition1 = racer1.Right - racetrack.Left;
            Car.RacetrackLength1 = racetrack.Size.Width - 100; //fixing length of race - till finish line

            Cars[0] = new Car() { carPictureBox = racer1 };
            Cars[1] = new Car() { carPictureBox = racer2 };
            Cars[2] = new Car() { carPictureBox = racer3 };
            Cars[3] = new Car() { carPictureBox = racer4 };

            punters[0] = pFactory.getPunter("avi", MaximumBet, aviBet); //
            punters[1] = pFactory.getPunter("gourav", MaximumBet, gouravBet); 
            punters[2] = pFactory.getPunter("vicky", MaximumBet, vickyBet); 


            foreach (Punter punter in punters)
            {
                punter.UpdateLabels();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void P1Button_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[0].money);
        }

        private void P2Button_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[1].money);
        }

        private void P3Button_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[2].money);
        }
        private void setMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = string.Format("Maximum Bet: ${0}", Cash);
        }

        private void Bets_Click(object sender, EventArgs e)
        {

            int PunterNum = 0;

            if (AviButton.Checked)
            {
                PunterNum = 0;
            }
            if (GouravButton.Checked)
            {
                PunterNum = 1;
            }
            if (VickyButton.Checked)
            {
                PunterNum = 2;
            }

            punters[PunterNum].PlaceBet((int)Amount.Value, (int)carNumber.Value);
            punters[PunterNum].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e)
        {


            bool NoWinner = true;
            int winningHorse;
            race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (Car.Run(Cars[i]))
                    {
                        winningHorse = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - Car" + winningHorse);
                        foreach (Punter punter in punters)
                        {
                            if (punter.startbet != null)
                            {
                                punter.Collect(winningHorse);
                                punter.startbet = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (Car Horse in Cars)
                        {
                            Horse.StartPosition();
                        }
                        break;
                    }
                }
            }
            if (punters[0].busted && punters[1].busted && punters[2].busted)
            {  //stop punters from betting if they run out of cash
                string message = "Do you want to Play Again?";
                string title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    Close();
                }

            }
            race.Enabled = true; //enable race button 
        }

        private void racetrack_Click(object sender, EventArgs e)
        {

        }
    }
}
