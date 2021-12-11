using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleveropdracht_1
{
    class Blackjack
    {
        public Table table;
        
        public void StartGame()
      {

            Console.WriteLine("aantal spelers:");
            int spelers = Int32.Parse(Console.ReadLine());

            Console.WriteLine("aantal kaarten per spelers:");
            int kaarten = Int32.Parse(Console.ReadLine());

            table = new Table(spelers, kaarten);
        }

        private void DealCards(List<Card> cards)
        {

        }
    }
}
