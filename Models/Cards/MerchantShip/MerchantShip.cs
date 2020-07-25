using System.ComponentModel.DataAnnotations.Schema;

namespace LootGame.Models.Cards
{
    [NotMapped]
    public class MerchantShip : Card
    {
        public MerchantShip(string type = "MerchantShip", string color = "", int atkStr = 0, int gValue = 0) : base(type, color, atkStr, gValue) { }
    }
}