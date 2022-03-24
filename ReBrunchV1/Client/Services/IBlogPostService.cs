using ReBrunchV1.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReBrunchV1.Client.Services
{
    interface IBlogPostService
    {
        Task<List<BlogPost>> GetBlogPosts();
        Task<BlogPost> GetBlogPostByUrl(string url);
    }
}
