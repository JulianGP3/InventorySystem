﻿// <auto-generated />
using Inventory.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.Models.Models.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InventoryItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Product A",
                            Price = 19.99m,
                            Quantity = "100"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Product B",
                            Price = 29.99m,
                            Quantity = "50"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Product C",
                            Price = 9.99m,
                            Quantity = "75"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
