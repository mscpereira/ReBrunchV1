using ReBrunchV1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReBrunchV1.Client.Services
{
    public class BlogPostService : IBlogPostService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost { Id = 1, Url = "first-post", DateCreated = new DateTime(2021, 10, 01), Restaurant = "Canto dos Sabores", Title= "Our first review, a magical experience!", Description ="This is our very first Post. From the eggs to the bread, all perfect."},
            new BlogPost { Id = 2, Url = "second-post", DateCreated = new DateTime(2022, 02, 22), Restaurant = "Pátio dos Petiscos", Title= "Our second review, a bad experience!", Description ="This is our second experience. From the milk to the ham, low on both quality and quantity."}
        };
        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}
