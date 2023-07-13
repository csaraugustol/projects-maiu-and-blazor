using AppBookStore.Blazor.Server.UI.Services.Base;

namespace AppBookStore.Blazor.Server.UI.Services.Author
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
        Task<Response<AuthorDetailsDto>> GetAuthor(int id);
        Task<Response<AuthorUpdateDto>> GetAuthorForUpdate(int id);
        Task<Response<int>> Create(AuthorCreateDto authorDto);
        Task<Response<int>> Edit(int id, AuthorUpdateDto authorDto);
        Task<Response<int>> Delete(int id);
    }
}