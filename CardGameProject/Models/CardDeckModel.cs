namespace CardGameProject.Models
{
    public class CardDeckModel
    {
        public bool Success { get; set; }
        public string DeckId { get; set; }
        public Card[] Cards { get; set; }
        public int Remaining { get; set; }
    }
}