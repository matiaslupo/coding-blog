using Microsoft.EntityFrameworkCore;
using Web.Models.Domain;

namespace Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options): base(options){ }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Category> Categories { get; set; }
}
