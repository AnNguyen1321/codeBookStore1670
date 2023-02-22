namespace Web_1670.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public List<Book> Book { get; set; }
    }
}
