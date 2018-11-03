using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryManagement.Core.BookManagement;
using LibraryManagement.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.WebApp.BookManagementApi
{
    [Produces("application/json")]
    [Route("api/Books")]
    public class BookController : Controller
    {
        private readonly IBookRepo _repo;
        private readonly IBookService _service;
        private readonly IReadModelDatabase _context;
        private readonly IMapper _mapper;

        public BookController(IBookRepo repo,IBookService service,IReadModelDatabase context,IMapper mapper)
        {
            _repo = repo;
            _service = service;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IEnumerable<BookListDto>> GetBooks()
        {
            var books = await _service.GetBook(); 

            return _mapper.Map<List<Book>,List<BookListDto>>(books).ToList();                  
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookDetailDto model)
        {
            await _service.NewBook(model.Name,model.AuthorId);
            return Ok();
        }
    }
}