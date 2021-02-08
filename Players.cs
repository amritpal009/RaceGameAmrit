using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGameAmrit
{
    using System.Windows.Forms;

    
   
        public class Avi : Punter // player1
        {
            public Avi(Bet MyBet, Label MaximumBet, int Money, Label MyLabel) : base(MyBet, MaximumBet, Money, MyLabel)
            {
            }

            public override void setPunterName()
            {
                Title = "Avi";
            }
        }

        public class Gourav : Punter  // player2
    {
            public Gourav(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
            {
            }

            public override void setPunterName()
            {
                Title = "Gourav";
            }
        }

        public class Vicky : Punter // player3
    {
            public Vicky(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
            {
            }

            public override void setPunterName()
            {
                Title = "Vicky";
            }
        }
    }

