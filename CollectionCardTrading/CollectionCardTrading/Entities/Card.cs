namespace CollectionCardTrading.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int Picture {  get; set; }
        public string Name { get; set; } = null!;
        public int Rarity { get; set; }
        public string Franchise { get; set; } = null!;
    }
}
