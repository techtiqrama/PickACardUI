using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // Get a random number from 1 to 4
            
            int Value = random.Next(1,5);

            // if it's 1 return the string Spades
            if (Value == 1) return "Spade";

            // if it's 2 return the string Hearts
            if (Value == 2) return "Hearts";

            // if it's 3 return the string Clubs
            if (Value == 3) return "Clubs";

            // if we have not returned yet, return the string Diamonds
            return "Diamonds";                
        }

        private static string RandomValue()
        {
            int Value = random.Next(1,14);

            if (Value ==  1) return "Ace";
            if (Value == 11) return "Jack";
            if (Value == 12) return "Queen";
            if (Value == 13) return "King";

            return Value.ToString();
        }
    }
}
