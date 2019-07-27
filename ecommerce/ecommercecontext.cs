using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;

namespace ecommerce
{
    public class ecommercecontext : DbContext
    {
        public ecommercecontext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionBuilder)
    {    //db bağlantısı
        dbContextOptionBuilder.UseSqlServer("Server=127.0.0.1;Database=ecommerce;User Id=sa;Password=123;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {        //db şeması
            //modelBuilder.Entity<user>().Property(a => a.Email).IsRequired();
            modelBuilder.Entity<category>().HasData(new category() {
                Id = 1,
                Name="Elektronik",
                Description="Ev elektriğine dair herşey"

            });
            modelBuilder.Entity<category>().HasData(new category()
            {
                Id = 2,
                Name = "Beyaz Eşya",
                Description = "Mutfak elektroniği"

            });
            modelBuilder.Entity<category>().HasData(new category()
            {
                Id = 3,
                Name = "Tekstil",
                Description = "Gardrobunuzu biz dolduruyoruz "

            });
            modelBuilder.Entity<State>().HasData(new State()
            {
                Id = 1,
                Name = "Aktif",
               
            });
            modelBuilder.Entity<State>().HasData(new State()
            {
                Id = 2,
                Name = "Pasif",

            });


        }
        public DbSet<user> users { get; set; }
        public DbSet<address> addresses { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<State> States { get; set; } 
    }
}

