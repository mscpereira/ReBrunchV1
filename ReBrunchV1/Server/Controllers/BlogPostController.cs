using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReBrunchV1.Server.Data;
using ReBrunchV1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReBrunchV1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        //In order to Go to DB get the data.
        private readonly DataContext _blogPostContext;
        public BlogPostController(DataContext blogPostContext)   //In order to Go to DB get the data.
        {
            _blogPostContext = blogPostContext;
        }

        [HttpGet]
        public ActionResult<List<BlogPost>> GetAllBlogPosts()
        {
            return Ok(_blogPostContext.BlogPosts);
        }


        [HttpGet("{url}")]
        public ActionResult<BlogPost> GetSingleBlogPost(string url)
        {
            var post = _blogPostContext.BlogPosts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));

            if (post == null)
            {
                return NotFound("This post doesn't exist.");

            }

            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<BlogPost>> CrateNewBlogPost(BlogPost request)
        {
            _blogPostContext.Add(request);
            await _blogPostContext.SaveChangesAsync();
            return request;
        }
    }
}
