namespace CollectionCardTrading.Entities
{
    public class Lot
    {
        public int Id { get; set; }
        public User User { get; set; }
        public bool Status { get; set; } //0 -- closed; 1 -- open
    }
}
