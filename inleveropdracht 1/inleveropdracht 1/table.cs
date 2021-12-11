using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleveropdracht_1
{
    class Table
    {
        private List<Player> spelers = new List<Player>();
        private House house;
        private List<Card> deck = new List<Card>();
        
        public Table(int spelersaantal, int aantalKaarten)
        {
            GenerateCards();

            for (int i = 0; i < spelersaantal; i++)
            {
                Player p = new Player();
                for (int j = 0; j < aantalKaarten; j++)
                {
                    p.TakeCard(deck, false);
                }
                spelers.Add(p);
            }
        }
        
        private void GenerateCards()
        {
            
        }
        private void Shuffle()
        {
            
        }
    }
}
