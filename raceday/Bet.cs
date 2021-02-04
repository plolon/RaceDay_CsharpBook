using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceday
{
    public class Bet
    {
        public int Amount; // ilość postawionych pieniędzy
        public int Dog; // Numer psa, na którego postawiono
        public Guy Bettor; // Facet, który zawarł zakład

        public string GetDescription()
        {
            if (Amount==0)
                return $"{Bettor.Name} nie zawarł zakładu";
            else
                return $"{Bettor.Name} obstawił {Amount} zł na psa numer {Dog}.";
        }
        public int PayOut(int Winner)
        {
            if (Dog==Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
