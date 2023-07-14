using AppBookStore.Blazor.WebAssembley.UI.Services.Book;
using AppBookStore.Blazor.WebAssembley.UI;
using AppBookStore.Blazor.WebAssembley.UI.Services.Authentication;
using AppBookStore.Blazor.WebAssembley.UI.Services.Author;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using AppBookStore.Blazor.WebAssembley.UI.Providers;
using Microsoft.AspNetCore.Components.Authorization;
using AppBookStore.Blazor.WebAssembley.UI.Services.Base;
using AppBookStore.Blazor.WebAssembley.UI.Configurations;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7259") });

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p =>
                p.GetRequiredService<ApiAuthenticationStateProvider>());
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<IClient, Client>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddAutoMapper(typeof(MapperConfig));


await builder.Build().RunAsync();
