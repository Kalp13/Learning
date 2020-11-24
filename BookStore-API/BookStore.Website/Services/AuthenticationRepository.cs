using Blazored.LocalStorage;
using BookStore.Website.Contracts;
using BookStore.Website.Models;
using BookStore.Website.Providers;
using BookStore.Website.Static;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Website.Services
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IHttpClientFactory httpClient;

        private readonly ILocalStorageService localStorage;

        private readonly AuthenticationStateProvider authentication;

        public AuthenticationRepository(IHttpClientFactory client, 
                                        ILocalStorageService localStorage, 
                                        AuthenticationStateProvider authentication)
        {
            this.httpClient = client;
            this.localStorage = localStorage;
            this.authentication = authentication;
        }

        public async Task<bool> Login(UserLoginModel user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Endpoints.LoginEndpoint);
            request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            var client = this.httpClient.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            var content = await response.Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<TokenResponseModel>(content);

            //Store Token
            await this.localStorage.SetItemAsync<string>("authToken", token.Token);

            //Change auth state of app
            await ((ApiAuthenticationStateProvider)this.authentication).LogggedIn();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.Token);

            return true;
        }

        public async Task LogOut()
        {
            await this.localStorage.RemoveItemAsync("authToken");
            await ((ApiAuthenticationStateProvider)this.authentication).LoggedOut();
        }

        public async Task<bool> Register(UserRegistrationModel user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Endpoints.RegisterEndpoint);
            request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            var client = this.httpClient.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            return response.IsSuccessStatusCode;
        }
    }
}
