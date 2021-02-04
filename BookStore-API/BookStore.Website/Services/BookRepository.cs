using Blazored.LocalStorage;
using BookStore.Website.Contracts;
using BookStore.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStore.Website.Services
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
