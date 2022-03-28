using Microsoft.EntityFrameworkCore;
using ReBrunchV1.Shared;

namespace ReBrunchV1.Server.Data
{
    //whit DbContext (using EFcore) we can then access our BlogPosts in our DB
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
