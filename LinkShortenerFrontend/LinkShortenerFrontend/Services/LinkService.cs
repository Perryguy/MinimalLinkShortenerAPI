using LinkShortenerFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenerFrontend.Services
{

    public class LinkService : ILinkService
    {

        private readonly HttpClient _httpClient;


        public LinkService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<LinkModel>> GetLinks()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "links/");
            HttpResponseMessage response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<LinkModel>>();
            }
            else
            {
                return new List<LinkModel>();
            }

        }
    }
}
