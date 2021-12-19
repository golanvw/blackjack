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
        
        public void AddPlayer(string name)
        {


        }
        
        
        
        private void GenerateCards()
        {
            
            string[] suits = new string[] { "Harten", "Schoppen", "Klaver", "Ruiten" };
            string[] ranks = new string[] { "1", "2", "3", "4", "5", "6","7","8","9","10"};


            for (int i = 0; i < suits.Length; i++) {
                for (int j = 0; j < ranks.Length; j++) {
                    deck.Add(new Card (ranks[j], suits[i]));
                                       
                }
                
            
            }  
            
        }
        private void Shuffle()
        {
            var rrr = new Random();
            for (int i = 0; 1<9000; i++ )
            {
                var kaart = deck[rrr.Next(0, deck.Count())];
                deck.Remove(kaart);
                deck.Insert(0, kaart);

            }
            
            
            
            
            
            
        }
    }
}
