﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaPub.Data;

#nullable disable

namespace ProvaPub.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20230404172227_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProvaPub.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alyssa Baumbach"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Caleb Mayert"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Nathan Kertzmann"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Melanie Prosacco"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kent Wunsch"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Robin Pfannerstill"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Albert Monahan"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Jeremiah Botsford"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Claude Heaney"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Bernard Purdy"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Lucy Mosciski"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Blake Donnelly"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Ginger Muller"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Ben Baumbach"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Arthur Nicolas"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Arthur Huel"
                        },
                        new
                        {
                            Id = 17,
                            Name = "June Jones"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Sergio Heaney"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Michael Metz"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Christine Kutch"
                        });
                });

            modelBuilder.Entity("ProvaPub.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Unbranded Metal Keyboard"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Refined Rubber Table"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Practical Metal Towels"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fantastic Wooden Chair"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Gorgeous Granite Car"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sleek Fresh Salad"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sleek Fresh Cheese"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Refined Granite Shirt"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Awesome Concrete Bacon"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tasty Frozen Mouse"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Licensed Fresh Tuna"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Unbranded Rubber Shoes"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Handcrafted Cotton Shoes"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Generic Rubber Shirt"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Sleek Concrete Bike"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Generic Concrete Tuna"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Refined Granite Chicken"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Rustic Frozen Chicken"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Fantastic Metal Table"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Fantastic Rubber Shoes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
