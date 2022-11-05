using Microsoft.EntityFrameworkCore;
using Proj3Mvc.Models;

namespace Proj3Mvc.Data;
public class AppDbContext : DbContext
{
    public DbSet<SonEntity>? SonEntitylar { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

    public AppDbContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<SonEntity>().HasData(new List<SonEntity>()
        {
            new SonEntity()
            {
                Id = 1000000000,
                Number = 1000000000,
                Ifoda = " milliard"
            },
            new SonEntity()
            {
                Id = 1000000,
                Number = 1000000,
                Ifoda = " million"
            },
            new SonEntity()
            {
                Id = 1000,
                Number = 1000,
                Ifoda = " ming"
            },
            new SonEntity()
            {
                Id = 100,
                Number = 100,
                Ifoda = " yuz"
            },
            new SonEntity()
            {
                Id = 90,
                Number = 90,
                Ifoda = " to'qson"
            },
            new SonEntity()
            {
                Id = 80,
                Number = 80,
                Ifoda = " sakson"
            },
            new SonEntity()
            {
                Id = 70,
                Number = 70,
                Ifoda = " yetmish"
            },
            new SonEntity()
            {
                Id =60,
                Number = 60,
                Ifoda = " oltmish"
            },
            new SonEntity()
            {
                Id = 50,
                Number = 50,
                Ifoda = " ellik"
            },
            new SonEntity()
            {
                Id = 40,
                Number = 40,
                Ifoda = " qirq"
            },
            new SonEntity()
            {
                Id = 30,
                Number = 30,
                Ifoda = " o'ttiz"
            },
            new SonEntity()
            {
                Id = 20,
                Number = 20,
                Ifoda = " yigirma"
            },
            new SonEntity()
            {
                Id = 10,
                Number = 10,
                Ifoda = " o'n"
            },
            new SonEntity()
            {
                Id = 9,
                Number = 9,
                Ifoda = " to'qqiz"
            },
            new SonEntity()
            {
                Id = 8,
                Number = 8,
                Ifoda = " sakkiz"
            },
            new SonEntity()
            {
                Id = 7,
                Number = 7,
                Ifoda = " yetti"
            },
            new SonEntity()
            {
                Id = 6,
                Number = 6,
                Ifoda = " olti"
            },
            new SonEntity()
            {
                Id = 5,
                Number = 5,
                Ifoda = " besh"
            },
            new SonEntity()
            {
                Id = 4,
                Number = 4,
                Ifoda = " to'rt"
            },
            new SonEntity()
            {
                Id = 3,
                Number = 3,
                Ifoda = " uch"
            },
            new SonEntity()
            {
                Id = 2,
                Number = 2,
                Ifoda = " ikki"
            },
            new SonEntity()
            {
                Id = 1,
                Number = 1,
                Ifoda = " bir"
            },
        });
    }
}