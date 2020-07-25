using System;
using System.Collections.Generic;

namespace LootGame.Models
{
    public class DrawPile
    {
        // Give DrawPile class a property called "cards" which is a list of Card objects
        public List<Card> cards;
        // [] Initialize the DrawPile, make sure all Captures and DiscardPile are emptied and has a list of all cards for the game as "cards" property
        public DrawPile()
        {
            Reset();
        }
        // [] DrawPile has Deal method that takes the "top" card, remove it from drawpile list and returns the Card.
        public Card Deal()
        {
            Card topMost = cards[0];
            cards.RemoveAt(0);
            return topMost;
        }
        // [] DrawPile has a Reset method that resets the cards property to back to start of game shuffled
        public void Reset()
        {
            // blaaaa
            // CREATE ALL THE STARTING CARDS HERE
            // IMAGINE MANY MANY LOOPS AND BASIC INSTANTIATION
            cards = new List<Card>();
            string type = "";
            string color = "";
            int atkStr = 0;
            int goldValue = 0;
            Card oneCard = new Card(type, color, atkStr, goldValue);
            cards.Add(oneCard);
        }
        // [x] DrawPile has Shuffle method that randomly reorders all the cards
        public void Shuffle()
        {
            // Fisher Yates Shuffle
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int r = random.Next(0, cards.Count - 1);
                Card temp = cards[r];
                cards[r] = cards[i];
                cards[i] = temp;
            }
        }
    }
}