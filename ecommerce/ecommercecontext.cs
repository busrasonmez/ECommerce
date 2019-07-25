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

    }
    public DbSet<user> users { get; set; }
        public DbSet<address> addresses { get; set; }
    }
}

