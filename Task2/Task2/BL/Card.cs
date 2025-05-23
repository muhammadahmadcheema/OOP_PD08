﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Card
    {
        private int value;
        private int suit;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int GetValue()
        {
            return value;
        }

        public int GetSuit()
        {
            return suit;
        }

        public string getValueAsString()
        {
            if (value == 1)
            {
                return "Ace";
            }
            else if (value == 11)
            {
                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            else
            {
                return value.ToString();
            }
        }

        public string getSuitAsString()
        {
            if (suit == 1)
            {
                return "Hearts";
            }
            else if (suit == 2)
            {
                return "Diamonds";
            }
            else if (suit == 3)
            {
                return "Clubs";
            }
            else
            {
                return "Spades";
            }
        }

        public string toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
    }
}
