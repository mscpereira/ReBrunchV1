using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReBrunchV1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReBrunchV1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>
        {
            new BlogPost { Id = 1, Url = "first-post", DateCreated = new DateTime(2021, 10, 01), Restaurant = "Canto dos Sabores", Title= "Our first review, a magical experience API!", Description ="This is our very first Post. From the eggs to the bread, all perfect."},
            new BlogPost { Id = 2, Url = "second-post", DateCreated = new DateTime(2022, 02, 22), Restaurant = "Pátio dos Petiscos", Title= "Our second review, a bad experience API!", Description ="This is our second experience. From the milk to the ham, low on both quality and quantity."}
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> GetAllBlogPosts()
        {
            return Ok(Posts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GetSingleBlogPost(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));

            if (post == null)
            {
                return NotFound("This post does not exist.");

            }

            return Ok(post);
        }
    }
}
