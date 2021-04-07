using Blazored.LocalStorage;
using BookStore.WASM.Contracts;
using BookStore.WASM.Models;

namespace BookStore.WASM.Services
{
    public class AuthorRepository : BaseRepository<AuthorModel>, IAuthorRepository
    {
        private readonly IHttpClientFactory clientFactory;

        private readonly ILocalStorageService localStorage;

        public AuthorRepository(IHttpClientFactory client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this.clientFactory = client;
            this.localStorage = localStorage;
        }
    }
}
