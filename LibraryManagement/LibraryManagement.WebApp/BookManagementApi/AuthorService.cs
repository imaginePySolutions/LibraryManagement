using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Core.BookManagement;
using LibraryManagement.Persistance;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.WebApp.BookManagementApi
{
    public class AuthorService : IAuthorService
    {
        private readonly IReadModelDatabase _database;
        public AuthorService(IReadModelDatabase database)
        {
            _database = database;

        }
        public Task<List<Author>> GetAuthors()
        {
            var authors = _database.Authors.ToListAsync();
            return authors;
        }
    }
}