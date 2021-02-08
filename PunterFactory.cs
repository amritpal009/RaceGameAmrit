using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGameAmrit
{
    public class PunterFactory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "avi":
                    p = new Avi(null, MaximumBet, 50, bet);
                    break;

                case "gourav":
                    p = new Gourav(null, MaximumBet, 50, bet);
                    break;

                case "vicky":
                    p = new Vicky(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
