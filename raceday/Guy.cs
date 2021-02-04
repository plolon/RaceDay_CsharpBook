using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceday
{
    public class Guy
    {
        public string Name; // Imię
        public Bet MyBet; // Instancja klasy Bet przechowująca dane o zakładzie
        public int Cash; // Jak dużo pieniędzy posiada

        // kontrolki GUI na formularzu
        public RadioButton myRadioButton; // moje pole wyboru
        public Label MyLabel; // moja etykieta

        public void UpdateLabel()
        {
            MyLabel.Text = MyBet.GetDescription();
            myRadioButton.Text = $"{Name} ma {Cash} zł";
        }
        public void ClearBet()
        {
            MyBet.Amount = 0;
        }
        public bool PlaceBet(int Amount, int DogToWin)
        {
            MyBet.Amount = Amount;
            MyBet.Dog = DogToWin;
            if (Cash >= Amount)
                return true;
            else return false;
        }
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabel();
        }
    }
}
