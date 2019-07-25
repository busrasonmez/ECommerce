﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce;

namespace ecommerce.Migrations
{
    [DbContext(typeof(ecommercecontext))]
    [Migration("20190725181759_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ecommerce.Models.address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OpenAddress");

                    b.Property<int?>("userId");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("ecommerce.Models.user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ecommerce.Models.address", b =>
                {
                    b.HasOne("ecommerce.Models.user", "user")
                        .WithMany("addresses")
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}
