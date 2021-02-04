using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceday
{
    public class Greyhound
    {
        public int StartingPosition; // Miejsce, gdzie rozpoczyna się PictureBox
        public int RacetrackLength; // Jak długa jest trasa
        public PictureBox MyPictureBox = null; // Mój obiekt PictureBox
        public int Location = 18; // Moje położenie na torze wyścigowym
        public Random MyRandom; // Instancja klasy random

        public bool Run()
        {
            Location += MyRandom.Next(1, 5);
            if (Location > RacetrackLength)
                return true;
            else
                return false;
        }
        public void TakeStartingPosition()
        {
            Location = StartingPosition;
        }
    }
}
