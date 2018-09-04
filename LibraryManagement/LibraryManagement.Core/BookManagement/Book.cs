using System;

namespace LibraryManagement.Core.BookManagement
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public Book()
       {
        
       }

       public static Book Create(string name,Author author)
      {
          var createBooks = new Book
          {
              Id = new int(),
              Name = name,
              AuthorId = author?.Id ?? throw new ArgumentNullException(nameof(author))

          };  

          return createBooks;
      } 
        
    }
    
    

    
    
}