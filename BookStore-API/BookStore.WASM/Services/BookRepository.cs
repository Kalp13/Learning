using Blazored.LocalStorage;
using BookStore.WASM.Contracts;
using BookStore.WASM.Models;

namespace BookStore.WASM.Services
{
    public class BookRepository : BaseRepository<BookModel>, IBookRepository
    {
        private readonly IHttpClientFactory clientFactory;

        private readonly ILocalStorageService localStorage;

        public BookRepository(IHttpClientFactory client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this.clientFactory = client;
            this.localStorage = localStorage;
        }
    }
}
