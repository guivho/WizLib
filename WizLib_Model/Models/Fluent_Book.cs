namespace WizLib_Model.Models
{
    public class Fluent_Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string  ISBN { get; set; }
        public double Price { get; set; }

        public int BookDetailId { get; set; }
        public Fluent_BookDetail Fluent_BookDetail { get; set; }

        public int PublisherId { get; set; }
        public Fluent_Publisher Fluent_Publisher { get; set; }
    }
}
