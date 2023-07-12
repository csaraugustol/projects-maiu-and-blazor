using AppBookStore.Blazor.Server.UI.Services.Base;

namespace AppBookStore.Blazor.Server.UI.Services.Author
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
        //Task<Response<AuthorDetailsDto>> Get(int id);
        //Task<Response<AuthorUpdateDto>> GetForUpdate(int id);
        Task<Response<int>> Create(AuthorCreateDto authorDto);
        //Task<Response<int>> Edit(int id, AuthorUpdateDto author);
        //Task<Response<int>> Delete(int id);
    }
}