using CafeDine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeDine.DAL
{
    public class DineContext : DbContext
    {
        public DineContext(DbContextOptions<DineContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Food> Foods { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
                new Slider { Id = 1, Image = "pizza.jpg", Title = " <span class='text-white'> Welcome to restuarant</span> ", Paragraph = " <h1 class='text-white'>Fresh,Delicious meal to reach your optimum health and fitness</h1>", Button = "<a class='btn btn-main mr-3' data-swiper-parallax='500'>View Menu</a>" },
                new Slider { Id = 2, Image = "pizza2.jpg", Title = " <span class='text-white'>Welcome to restuarant</span> ", Paragraph = "<h1 class='text-white'>Good food starts with good ingridients.Have a great time with us</h1>", Button = "<a class='btn btn-main mr-3' data-swiper-parallax='500'>View Menu</a>" },
                new Slider { Id = 3, Image = "pizza3.jpg", Title = " <span class='text-white'>Welcome to restuarant</span> ", Paragraph = "<h1 class='text-white'>We deliver good quality food with great service to our customers</h1>", Button = "<a class='btn btn-main mr-3' data-swiper-parallax='500'>View Menu</a>" }
            );

            modelBuilder.Entity<Food>().HasData(
         new Food { Id = 1, Logo = " <i class='icofont-soup-bowl'></i>", Title = "<h3 class='mt-3'>Delicious Food</h3>", Paragraph = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia animi ipsam obcaecati.</p>" },
         new Food { Id = 2, Logo = " <i class='icofont-tasks'></i>", Title = "<h3class='mt-3'>Online Order</h3>", Paragraph = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia animi ipsam obcaecati.</p>" },
         new Food { Id = 3, Logo = "<i class='icofont-map-pins'></i>", Title = "<h3 class='mt-3'>Free delivery</h3>", Paragraph = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia animi ipsam obcaecati.</p>" }

     );
        }


    }
}
