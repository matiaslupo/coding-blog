using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options): base(options) { }

    public DbSet<BlogPost> Posts { get; set; }
}
