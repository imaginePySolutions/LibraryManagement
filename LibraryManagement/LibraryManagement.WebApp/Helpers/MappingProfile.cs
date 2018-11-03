using AutoMapper;
using LibraryManagement.Core.BookManagement;
using LibraryManagement.WebApp.BookManagementApi;

namespace LibraryManagement.WebApp.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book,BookListDto>();
            CreateMap<Book,BookDetailDto>(); 
            CreateMap<Author,AuthorDto>();
        }
    }
}