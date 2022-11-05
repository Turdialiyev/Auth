using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Project.Data;

public class AppDbContext : DbContext
{
    public DbSet<Number>? Numbers { get; set; }
    public DbSet<NumberValue>? NumberValues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder
            .UseSqlite("Data Source=Project.sqlite");

    }
}