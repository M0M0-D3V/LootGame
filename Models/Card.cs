using System.ComponentModel.DataAnnotations.Schema;

namespace LootGame.Models
{
    [NotMapped]
    public class Card
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int AttackStrength { get; set; }
        public int GoldValue { get; set; }
        public Card(string type, string title, int atkStr = 0, int gValue = 0)
        {
            Type = type;
            Title = title;
            AttackStrength = atkStr;
            GoldValue = gValue;
        }
        public virtual void Player(Player player)
        {
            player.TotalGold += GoldValue;
        }
    }
}