using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data;
public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions options)
    : base(options)
    {

    }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Stock> Stocks { get; set; }
}