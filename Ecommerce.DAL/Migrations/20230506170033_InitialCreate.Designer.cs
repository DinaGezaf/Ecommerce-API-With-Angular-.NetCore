﻿// <auto-generated />
using Ecommerce.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.DAL.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230506170033_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.DAL.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<int>("ProductBrandId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/sb-ang1.png",
                            Price = 200m,
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                            Title = "Angular Speedster Board 2000"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            PictureUrl = "images/products/sb-ang2.png",
                            Price = 150m,
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                            Title = "Green Angular Board 3000"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/sb-core1.png",
                            Price = 180m,
                            ProductBrandId = 2,
                            ProductTypeId = 1,
                            Title = "Core Board Speed Rush 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/sb-core2.png",
                            Price = 300m,
                            ProductBrandId = 2,
                            ProductTypeId = 1,
                            Title = "Net Core Super Board"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/sb-react1.png",
                            Price = 250m,
                            ProductBrandId = 4,
                            ProductTypeId = 1,
                            Title = "React Board Super Whizzy Fast"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            PictureUrl = "images/products/sb-ts1.png",
                            Price = 120m,
                            ProductBrandId = 5,
                            ProductTypeId = 1,
                            Title = "Typescript Entry Board"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/hat-core1.png",
                            Price = 10m,
                            ProductBrandId = 2,
                            ProductTypeId = 2,
                            Title = "Core Blue Hat"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/hat-react1.png",
                            Price = 8m,
                            ProductBrandId = 4,
                            ProductTypeId = 2,
                            Title = "Green React Woolen Hat"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/hat-react2.png",
                            Price = 15m,
                            ProductBrandId = 4,
                            ProductTypeId = 2,
                            Title = "Purple React Woolen Hat"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            PictureUrl = "images/products/glove-code1.png",
                            Price = 18m,
                            ProductBrandId = 3,
                            ProductTypeId = 4,
                            Title = "Blue Code Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/glove-code2.png",
                            Price = 15m,
                            ProductBrandId = 3,
                            ProductTypeId = 4,
                            Title = "Green Code Gloves"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa.",
                            PictureUrl = "images/products/glove-react1.png",
                            Price = 16m,
                            ProductBrandId = 4,
                            ProductTypeId = 4,
                            Title = "Purple React Gloves"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/glove-react2.png",
                            Price = 14m,
                            ProductBrandId = 4,
                            ProductTypeId = 4,
                            Title = "Green React Gloves"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/boot-redis1.png",
                            Price = 250m,
                            ProductBrandId = 6,
                            ProductTypeId = 3,
                            Title = "Redis Red Boots"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/boot-core2.png",
                            Price = 189m,
                            ProductBrandId = 2,
                            ProductTypeId = 3,
                            Title = "Core Red Boots"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/boot-core1.png",
                            Price = 199m,
                            ProductBrandId = 2,
                            ProductTypeId = 3,
                            Title = "Core Purple Boots"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            PictureUrl = "images/products/boot-ang2.png",
                            Price = 150m,
                            ProductBrandId = 1,
                            ProductTypeId = 3,
                            Title = "Angular Purple Boots"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/boot-ang1.png",
                            Price = 180m,
                            ProductBrandId = 1,
                            ProductTypeId = 3,
                            Title = "Angular Blue Boots"
                        });
                });

            modelBuilder.Entity("Ecommerce.DAL.Data.Models.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Angular"
                        },
                        new
                        {
                            Id = 2,
                            Name = "NetCore"
                        },
                        new
                        {
                            Id = 3,
                            Name = "VS Code"
                        },
                        new
                        {
                            Id = 4,
                            Name = "React"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Typescript"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Redis"
                        });
                });

            modelBuilder.Entity("Ecommerce.DAL.Data.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Boards"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hats"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Boots"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gloves"
                        });
                });

            modelBuilder.Entity("Ecommerce.DAL.Data.Models.Product", b =>
                {
                    b.HasOne("Ecommerce.DAL.Data.Models.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.DAL.Data.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });
#pragma warning restore 612, 618
        }
    }
}
