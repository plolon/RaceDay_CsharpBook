using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[3];
        int ticks = 0;
        Random randomizer = new Random();
        int winner;


        private void Form1_Load(object sender, EventArgs e)
        {
            minimumBetLabel.Text = $"Minimalny zakład: {moneyUpDown.Minimum}";

            greyhounds[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = pictureBox1.Width - pictureBox2.Width,
                MyRandom = randomizer
            };
            greyhounds[1] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = pictureBox1.Width - pictureBox3.Width,
                MyRandom = randomizer
            };
            greyhounds[2] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = pictureBox1.Width - pictureBox4.Width,
                MyRandom = randomizer
            };
            greyhounds[3] = new Greyhound()
            {
                MyPictureBox = pictureBox5,
                StartingPosition = pictureBox5.Left,
                RacetrackLength = pictureBox1.Width - pictureBox5.Width,
                MyRandom = randomizer
            };
            guys[0] = new Guy()
            {
                Name = "Janek",
                MyBet = null,
                Cash = 50,
                myRadioButton = janekRadioButton,
                MyLabel = janekBetLabel
            };
            guys[1] = new Guy()
            {
                Name = "Bartek",
                MyBet = null,
                Cash = 75,
                myRadioButton = bartekRadioButton,
                MyLabel = bartekBetLabel
            };
            guys[2] = new Guy()
            {
                Name = "Arek",
                MyBet = null,
                Cash = 45,
                myRadioButton = arekRadioButton,
                MyLabel = arekBetLabel
            };

            for(int i=0; i<3; i++)
            {
                guys[i].MyBet = new Bet()
                {
                    Bettor = guys[i]
                };

                guys[i].ClearBet();
                guys[i].UpdateLabel();

            }

            nameLabel.Text = guys[0].Name;

        }
        int x = 0;

        private void janekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            x = 0;
            nameLabel.Text = guys[0].Name;
        }

        private void bartekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            x = 1;
            nameLabel.Text = guys[1].Name;
        }

        private void arekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            x = 2;
            nameLabel.Text = guys[2].Name;
        }

        private void minimumBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (guys[x].PlaceBet(Decimal.ToInt32(moneyUpDown.Value), Decimal.ToInt32(dogUpDown.Value)))
                guys[x].UpdateLabel();
            else
                MessageBox.Show("tero nie");

        }

        private void moneyUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!greyhounds[0].Run())
            {
                pictureBox2.Location = new Point(greyhounds[0].Location, pictureBox2.Location.Y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Zwyciężył pies nr 1!");
                winner = 1;
                Koniec();
            }
            if (!greyhounds[1].Run())
            {
                pictureBox3.Location = new Point(greyhounds[1].Location, pictureBox3.Location.Y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Zwyciężył pies nr 2!");
                winner = 2;
                Koniec();
            }
            if (!greyhounds[2].Run())
            {
                pictureBox4.Location = new Point(greyhounds[2].Location, pictureBox4.Location.Y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Zwyciężył pies nr 3!");
                winner = 3;
                Koniec();
            }
            if (!greyhounds[3].Run())
            {
                pictureBox5.Location = new Point(greyhounds[3].Location, pictureBox5.Location.Y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Zwyciężył pies nr 4!");
                winner = 4;
                Koniec();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Disable(true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        public void Koniec()
        {
            for (int i = 0; i < 4; ++i)
            {
                greyhounds[i].TakeStartingPosition();
                pictureBox2.Location = new Point(greyhounds[0].Location, pictureBox2.Location.Y);
                pictureBox3.Location = new Point(greyhounds[1].Location, pictureBox3.Location.Y);
                pictureBox4.Location = new Point(greyhounds[2].Location, pictureBox4.Location.Y);
                pictureBox5.Location = new Point(greyhounds[3].Location, pictureBox5.Location.Y);
            }
            for (int i = 0; i < 3; ++i)
            {
                if (guys[i].MyBet.Amount != 0)
                {
                    guys[i].Collect(winner);
                    guys[i].ClearBet();
                    guys[i].UpdateLabel();
                }
            }
            MessageBox.Show("Wydałem zakłady, psy wróciły na start");
            winner = 0;
            Disable(false);
        }
        public void Disable(bool start)
        {
            if (start)
            {
                startButton.Enabled = false;
                janekRadioButton.Enabled = false;
                bartekRadioButton.Enabled = false;
                arekRadioButton.Enabled = false;
                betButton.Enabled = false;
            }
            else
            {
                startButton.Enabled = true;
                janekRadioButton.Enabled = true;
                bartekRadioButton.Enabled = true;
                arekRadioButton.Enabled = true;
                betButton.Enabled = true;
            }

        }

    }
}
