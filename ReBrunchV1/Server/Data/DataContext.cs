using Microsoft.EntityFrameworkCore;
using ReBrunchV1.Shared;

namespace ReBrunchV1.Server.Data
{
    public class DataContext : DbContext //whit DbContext (using EFcore) we can then access our BlogPosts in our DB
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
