using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LootGame.Models
{
    [NotMapped]
    public class Player
    {
        // DETAILS ABOUT EACH PLAYER
        public string Name { get; set; }

        // [] Player with the most Gold points scored wins. This prop is modified when player attacks and captures a Merchant Ship

        public int TotalGold { get; set; }
        public int Action { get; set; }

        // [] Players Cards will be in 1 of 4 lists: CardsInHand, InPlay(onMerchantShip), Captured, or DiscardPile
        public List<Card> CardsInHand { get; set; }
        public List<Card> InPlay { get; set; }
        public List<Card> Captured { get; set; }
        public List<Card> DiscardPile { get; set; }

        /* [] PLAYER CONSTRUCTOR - Player starts the game with these:
                Name, CardsInHand, Action
        */
        public Player(string aName)
        {
            Name = aName;
            TotalGold = 0;
            CardsInHand = new List<Card>();
            Action = 1;
            TotalGold = 0;
        }

        // [] Draw Method to take top card from Game DrawPile deck passed in as parameter
        // [] Adds this card to Player's CardsInHand and returns the Card
        public Card Draw(DrawPile aDrawPile)
        {
            // [] replace new Card with the DrawPile.Deal() 
            Card drawCard = aDrawPile.Deal();
            CardsInHand.Add(drawCard);
            return drawCard;
        }

        // [] PlayCard Method to play specific card onto a target Merchant ship with necessary validations
        public void Play()
        {
            // Check if there is MerchantShip InPlay
            // Parameters: Card that Player is playing and which MerchantShip is being played on
        }
    }

}