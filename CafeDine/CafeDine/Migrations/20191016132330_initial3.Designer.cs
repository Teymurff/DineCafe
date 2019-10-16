﻿// <auto-generated />
using CafeDine.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CafeDine.Migrations
{
    [DbContext(typeof(DineContext))]
    [Migration("20191016132330_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CafeDine.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Button")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Paragraph")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new { Id = 1, Button = "<a>View Menu</a>", Image = "pizza.jpg", Paragraph = " <h1>Fresh,Delicious meal to reach your optimum health and fitness</h1>", Title = " <span>Welcome to restuarant</span> " },
                        new { Id = 2, Button = "<a>View Menu</a>", Image = "pizza2.jpg", Paragraph = "<h1>Good food starts with good ingridients.Have a great time with us</h1>", Title = " <span>Welcome to restuarant</span> " },
                        new { Id = 3, Button = "<a>View Menu</a>", Image = "pizza3.jpg", Paragraph = "<h1>We deliver good quality food with great service to our customers</h1>", Title = " <span>Welcome to restuarant</span> " }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
