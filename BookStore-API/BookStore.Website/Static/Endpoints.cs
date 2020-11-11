using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Website.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "https://localhost:44369/";

        public static string AuthorsEndpoint = $"{BaseUrl}api/authors/";

        public static string BookssEndpoint = $"{BaseUrl}api/books/";
    }
}
