using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGameAmrit
{
    public class Bet // beting class
    {
        public int Amount;
        public int Numcar;
        public Punter Bettor;

        public Bet(int Amount, int numcar, Punter Bettor)
        {
            this.Amount = Amount;
            this.Numcar = numcar;
            this.Bettor = Bettor;
        }

        public string GetDescription() 
        {
            string description = "";

            if (Amount > 0)
            {
                description = string.Format("{0} bets $ {1} on car number {2}", // bet on 
                    Bettor.Title, Amount, Numcar);
            }
            else
            {
                description = string.Format("{0} hasn't placed any bets",// bet has not placet yet
                    Bettor.Title);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (Numcar == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
