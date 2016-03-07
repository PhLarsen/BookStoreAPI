namespace BooksAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        
        public int Rating { get; set; }

        public virtual Book Book { get; set; }
    }
}