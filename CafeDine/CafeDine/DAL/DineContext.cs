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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Slider>().HasData(
            //    new Slider { Id = 1, Image = "banner1.jpg", Title = "The Biggest <span>Sale</span> ", SubTitle = "Special for today" },
            //    new Slider { Id = 2, Image = "banner2.jpg", Title = "SUMMER <span>COLLECTION </span> ", SubTitle = "New Arrivals On Sale" },
            //    new Slider { Id = 3, Image = "banner3.jpg", Title = "The Biggest <span>Sale</span> ", SubTitle = "Special for Kamran" },
            //    new Slider { Id = 4, Image = "banner4.jpg", Title = "The Biggest <span>Perviz ever</span> ", SubTitle = "Special for Ruslan" }
            //);
        }


    }
}
