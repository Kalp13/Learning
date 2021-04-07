using Blazored.LocalStorage;
using BookStore.WASM.Contracts;
using BookStore.WASM.Providers;
using BookStore.WASM.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStore.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(p => p.GetRequiredService<ApiAuthenticationStateProvider>());
            builder.Services.AddScoped<JwtSecurityTokenHandler>();
            builder.Services.AddTransient<IAuthenticationRepository, AuthenticationRepository>();
            builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();
            builder.Services.AddTransient<IBookRepository, BookRepository>();
            //builder.Services.AddTransient<IFileUpload, FileUpload>();

            await builder.Build().RunAsync();
        }
    }
}
