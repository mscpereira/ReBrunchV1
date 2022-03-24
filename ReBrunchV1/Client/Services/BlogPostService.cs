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

        //public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        //{
        //    new BlogPost { Id = 1, Url = "first-post-from-API", DateCreated = new DateTime(2021, 10, 01), Restaurant = "Canto dos Sabores", Title= "Our first review, a magical experience!", Description ="This is our very first Post. From the eggs to the bread, all perfect."},
        //    new BlogPost { Id = 2, Url = "second-post-from-API", DateCreated = new DateTime(2022, 02, 22), Restaurant = "Pátio dos Petiscos", Title= "Our second review, a bad experience!", Description ="This is our second experience. From the milk to the ham, low on both quality and quantity."}
        //};

        //public BlogPost GetBlogPostByUrl(string url)
        //{
        //    return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        //}

        //public List<BlogPost> GetBlogPosts()
        //{
        //    return Posts;
        //}

        //After passing the mocked data to the controller we need a constructor and make the web call assyncronous
        private readonly HttpClient _http;
        public BlogPostService(HttpClient http)
        {
            _http = http;
        }
        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var post = await _http.GetFromJsonAsync<BlogPost>($"api/BlogPost/{url}");
            return post;
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _http.GetFromJsonAsync<List<BlogPost>>("api/BlogPost");
        }
    }
}
