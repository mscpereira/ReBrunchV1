using ReBrunchV1.Shared;
using System.Collections.Generic;

namespace ReBrunchV1.Client.Services
{
    interface IBlogPostService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostByUrl(string url);
    }
}
