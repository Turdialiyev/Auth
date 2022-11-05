﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proj3Mvc.Data;

#nullable disable

namespace Proj3Mvc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Proj3Mvc.Models.SonEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ifoda")
                        .HasColumnType("TEXT");

                    b.Property<long>("Number")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SonEntitylar");

                    b.HasData(
                        new
                        {
                            Id = 1000000000L,
                            Ifoda = " milliard",
                            Number = 1000000000L
                        },
                        new
                        {
                            Id = 1000000L,
                            Ifoda = " million",
                            Number = 1000000L
                        },
                        new
                        {
                            Id = 1000L,
                            Ifoda = " ming",
                            Number = 1000L
                        },
                        new
                        {
                            Id = 100L,
                            Ifoda = " yuz",
                            Number = 100L
                        },
                        new
                        {
                            Id = 90L,
                            Ifoda = " to'qson",
                            Number = 90L
                        },
                        new
                        {
                            Id = 80L,
                            Ifoda = " sakson",
                            Number = 80L
                        },
                        new
                        {
                            Id = 70L,
                            Ifoda = " yetmish",
                            Number = 70L
                        },
                        new
                        {
                            Id = 60L,
                            Ifoda = " oltmish",
                            Number = 60L
                        },
                        new
                        {
                            Id = 50L,
                            Ifoda = " ellik",
                            Number = 50L
                        },
                        new
                        {
                            Id = 40L,
                            Ifoda = " qirq",
                            Number = 40L
                        },
                        new
                        {
                            Id = 30L,
                            Ifoda = " o'ttiz",
                            Number = 30L
                        },
                        new
                        {
                            Id = 20L,
                            Ifoda = " yigirma",
                            Number = 20L
                        },
                        new
                        {
                            Id = 10L,
                            Ifoda = " o'n",
                            Number = 10L
                        },
                        new
                        {
                            Id = 9L,
                            Ifoda = " to'qqiz",
                            Number = 9L
                        },
                        new
                        {
                            Id = 8L,
                            Ifoda = " sakkiz",
                            Number = 8L
                        },
                        new
                        {
                            Id = 7L,
                            Ifoda = " yetti",
                            Number = 7L
                        },
                        new
                        {
                            Id = 6L,
                            Ifoda = " olti",
                            Number = 6L
                        },
                        new
                        {
                            Id = 5L,
                            Ifoda = " besh",
                            Number = 5L
                        },
                        new
                        {
                            Id = 4L,
                            Ifoda = " to'rt",
                            Number = 4L
                        },
                        new
                        {
                            Id = 3L,
                            Ifoda = " uch",
                            Number = 3L
                        },
                        new
                        {
                            Id = 2L,
                            Ifoda = " ikki",
                            Number = 2L
                        },
                        new
                        {
                            Id = 1L,
                            Ifoda = " bir",
                            Number = 1L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
