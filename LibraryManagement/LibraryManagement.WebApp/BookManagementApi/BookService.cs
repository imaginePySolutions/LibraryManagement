using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Core.BookManagement;
using LibraryManagement.Core.ErrorHandling;
using LibraryManagement.Persistance;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.WebApp.BookManagementApi
{
    public class BookService : IBookService
    {
        private readonly IAuthorRepo _repo;
        private readonly IBookRepo _repoForBook;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReadModelDatabase _database;

        public BookService(IAuthorRepo repo, IBookRepo repoForBook, IUnitOfWork unitOfWork, IReadModelDatabase database)
        {
            _database = database;
            _repo = repo;
            _repoForBook = repoForBook;
            _unitOfWork = unitOfWork;
        }
        public async Task NewBook(string name, int authorId)
        {
            var author = await _repo.GetAsync(authorId);

            if (author == null)
                throw new Exception($"No Authors Found");

            var newBook = Book.Create(name, author);

            _repoForBook.Add(newBook);

            await _unitOfWork.CompleteAsync();

        }

        public async Task<List<Book>> GetBook()
        {
            var books = await _database.Books.ToListAsync();

            if(books == null)
                throw new ArgumentNullException($"No Books yet Created");

            return (books);
        }


    }
}