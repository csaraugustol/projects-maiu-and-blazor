using AppBookStore.Blazor.WebAssembley.UI.Services.Base;
using AutoMapper;

namespace AppBookStore.Blazor.WebAssembley.UI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorReadOnlyDto, AuthorUpdateDto>().ReverseMap();
            CreateMap<AuthorDetailsDto, AuthorUpdateDto>().ReverseMap();

            CreateMap<BookDetailsDto, BookUpdateDto>().ReverseMap();
        }
    }
}
