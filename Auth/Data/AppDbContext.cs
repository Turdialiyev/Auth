using Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User>? Users { get; set; }
    public DbSet<Role>? Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>().HasData(new User()
        {
            Id = 1,
            UserName = "admin",
            Password = "admin123",
        });
        builder.Entity<Role>().HasData(new Role()
        {
            Id = 1,
            Rol = "admin",
            UserId = 1,
        });
    }
}