using AppBookStore.Blazor.Server.UI.Services.Base;
using AutoMapper;

namespace AppBookStore.Blazor.Server.UI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorReadOnlyDto, AuthorUpdateDto>().ReverseMap();
        }
    }
}
