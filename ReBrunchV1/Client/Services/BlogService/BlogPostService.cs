using ReBrunchV1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ReBrunchV1.Client.Services
{
    public class BlogPostService : IBlogPostService
    {
        //Passed to the BLogPostController with Http Get
        //After passing the mocked data to the controller we need a constructor and make the web call assyncronous
        private readonly HttpClient _http;
        public BlogPostService(HttpClient http)
        {
            _http = http;
        }

        public async Task<BlogPost> CreateNewBlogPost(BlogPost request)
        {
            var result = await _http.PostAsJsonAsync("api/BlogPost", request);
            return await result.Content.ReadFromJsonAsync<BlogPost>();
        }

        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var result = await _http.GetAsync($"api/BlogPost/{url}");
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = await result.Content.ReadAsStringAsync();
                Console.WriteLine(message);
                return new BlogPost { Title = message };
            }
            else
            {
                return await result.Content.ReadFromJsonAsync<BlogPost>();
            }
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _http.GetFromJsonAsync<List<BlogPost>>("api/BlogPost");
        }
    }
}

