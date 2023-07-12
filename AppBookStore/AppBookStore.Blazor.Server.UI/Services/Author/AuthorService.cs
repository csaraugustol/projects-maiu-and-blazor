using AppBookStore.Blazor.Server.UI.Services.Base;
using Blazored.LocalStorage;
using System;

namespace AppBookStore.Blazor.Server.UI.Services.Author
{
    public class AuthorService : BaseHttpService, IAuthorService
    {
        private readonly IClient client;

        public AuthorService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this.client = client;
        }

        public async Task<Response<int>> Create(AuthorCreateDto authorDto)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.AuthorsPOSTAsync(authorDto);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<List<AuthorReadOnlyDto>>> GetAuthors()
        {
            Response<List<AuthorReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.AuthorsAllAsync();
                response = new Response<List<AuthorReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<AuthorReadOnlyDto>>(exception);
            }

            return response;
        }
    }
}
