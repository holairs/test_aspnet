using Microsoft.EntityFrameworkCore;
using web_test.Models.Domain;

namespace web_test.Data;

public class WebDbContext : DbContext
{
    public WebDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Tag> Tags { get; set; }
}