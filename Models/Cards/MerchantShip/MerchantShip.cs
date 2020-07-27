using System.ComponentModel.DataAnnotations.Schema;

namespace LootGame.Models.Cards
{
    [NotMapped]
    public class MerchantShip : Card
    {
        // Merchant ships have different values of Gold.
        public MerchantShip(string type = "MerchantShip", string color = "", int atkStr = 0, int gValue = 0) : base(type, color, atkStr, gValue) { }
    }
}