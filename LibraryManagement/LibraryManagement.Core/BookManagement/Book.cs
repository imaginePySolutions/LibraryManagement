namespace LibraryManagement.Core.BookManagement
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}