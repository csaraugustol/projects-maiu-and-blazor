using AppBookStore.Blazor.WebAssembley.UI.Services.Base;

namespace AppBookStore.Blazor.WebAssembley.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
