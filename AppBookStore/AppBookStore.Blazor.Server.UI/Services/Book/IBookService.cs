using AppBookStore.Blazor.Server.UI.Services.Base;

namespace AppBookStore.Blazor.Server.UI.Services.Book
{
    public interface IBookService
    {
        Task<Response<List<BookReadOnlyDto>>> GetBooks();
        Task<Response<BookDetailsDto>> GetBook(int id);
        Task<Response<BookUpdateDto>> GetBookForUpdate(int id);
        Task<Response<int>> Create(BookCreateDto bookDto);
        Task<Response<int>> Edit(int id, BookUpdateDto bookDto);
        Task<Response<int>> Delete(int id);
    }
}
