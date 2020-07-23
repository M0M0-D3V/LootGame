using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LootGame.Models
{
    [NotMapped]
    public class Player
    {
        // DETAILS ABOUT EACH PLAYER
        public string Name { get; set; }

        /* Player with the most Gold points scored wins
        this prop is modified when player attacks and captures a Merchant Ship
        */
        public int TotalGold { get; set; }

        /* Players Cards will be in 1 of 4 stacks: Hand, InPlay(onMerchantShip), Captured, or DiscardPile
        */
        public List<Card> Hand { get; set; }
        public List<Card> InPlay { get; set; }
        public List<Card> Captured { get; set; }
        public List<Card> DiscardPile { get; set; }
    }

}