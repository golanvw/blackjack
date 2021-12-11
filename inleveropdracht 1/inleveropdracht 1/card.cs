using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleveropdracht_1
{
    class Card
    {

        public string suit;
        public int rank;
        public int value;
        public int rnd;

        public Card(int s, int waarde)
        {
            value = waarde; // Sets the Value of the card to the value of v (The second argument)
            switch (s) // Case statement based on the value of s
            {
                case 1: // If s == 1, then set the Suit to Clubs
                    suit = "♣";
                    break;
                case 2: // If s == 2, then set the Suit to Diamonds
                    suit = "♦";
                    break;
                case 3: // If s == 3, then set the Suit to Hearts
                    suit = "♥";
                    break;
                case 4: // If s == 4, then set the Suit to Spades
                    suit = "♠";
                    break;
            }
            
            if (value > 10)
            {
                rank = 10;
            }
            else if (value == 1) // If it's an ace
            {
                rank = 11; // Set the points to 11
            }
            else
            {
                rank = value;
            }


        }
    }
}
