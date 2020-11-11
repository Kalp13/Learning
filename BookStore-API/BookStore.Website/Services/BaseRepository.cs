using BookStore.Website.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Website.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IHttpClientFactory clientFactory;

        public BaseRepository(IHttpClientFactory factory)
        {
            this.clientFactory = factory;
        }

        public async Task<bool> Create(string url, T newEntity)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            if (newEntity == null)
            {
                return false;
            }

            request.Content = new StringContent(JsonConvert.SerializeObject(newEntity));

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> Delete(string url, int id)
        {
            if (id <= 0)
            {
                return false;
            }

            var request = new HttpRequestMessage(HttpMethod.Delete, 
                            string.Format(CultureInfo.InvariantCulture, "{0}/{1}",url, id));

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }

            return false;
        }

        public async Task<T> Get(string url, int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, 
                            string.Format(CultureInfo.InvariantCulture, "{0}/{1}", url, id));

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content);
            }

            return null;
        }

        public async Task<IList<T>> Get(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IList<T>>(content);
            }

            return null;
        }

        public async Task<bool> Update(string url, T updatedEntity)
        {
            var request = new HttpRequestMessage(HttpMethod.Patch, 
                                string.Format(CultureInfo.InvariantCulture, "{0}", url));

            if (updatedEntity == null)
            {
                return false;
            }

            request.Content = new StringContent(JsonConvert.SerializeObject(updatedEntity), 
                                                Encoding.UTF8, 
                                                "application/json");

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }

            return false;
        }
    }
}
