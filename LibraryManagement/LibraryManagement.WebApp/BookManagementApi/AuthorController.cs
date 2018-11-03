using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryManagement.Core.BookManagement;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.WebApp.BookManagementApi
{
    public class AuthorController : Controller
    {
        private readonly IAuthorRepo _authorRepo;
        private readonly IMapper _mapper;
        private readonly IAuthorService _service;
        public AuthorController(IAuthorRepo authorRepo, IMapper mapper, IAuthorService service)
        {
            _service = service;
            _mapper = mapper;
            _authorRepo = authorRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<AuthorDto>> GetAuthors()
        {
            var authors = await _service.GetAuthors();

            return _mapper.Map<List<Author>, List<AuthorDto>>(authors).ToList();
        }

    }
}