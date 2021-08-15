﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Safebook.EfCore.EFData;

namespace SafeBook.EfCore.Migrations
{
    [DbContext(typeof(SafeBookDbContext))]
    [Migration("20210811221149_CategorysAndProductsConfig")]
    partial class CategorysAndProductsConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SafeBook.Domain.Common.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SafeBook.Domain.Common.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SecondtName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SafeBook.Domain.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("SafeBook.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SafeBook.Domain.Shop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DefaultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DefaultPrice = 2.99m,
                            Description = "",
                            Name = "Ołówek 1",
                            ProductCategoryId = 2
                        },
                        new
                        {
                            Id = 2,
                            DefaultPrice = 3.99m,
                            Description = "",
                            Name = "Ołówek 2",
                            ProductCategoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            DefaultPrice = 10m,
                            Description = "",
                            Name = "Ołówek 3",
                            ProductCategoryId = 2
                        },
                        new
                        {
                            Id = 4,
                            DefaultPrice = 25.99m,
                            Description = "",
                            Name = "Kubek 1",
                            ProductCategoryId = 1
                        },
                        new
                        {
                            Id = 5,
                            DefaultPrice = 10.99m,
                            Description = "",
                            Name = "Kubek 2",
                            ProductCategoryId = 1
                        },
                        new
                        {
                            Id = 6,
                            DefaultPrice = 14m,
                            Description = "",
                            Name = "Kubek 3",
                            ProductCategoryId = 1
                        },
                        new
                        {
                            Id = 7,
                            DefaultPrice = 39m,
                            Description = "",
                            Name = "Tłumik skrzypcowy",
                            ProductCategoryId = 3
                        },
                        new
                        {
                            Id = 8,
                            DefaultPrice = 59m,
                            Description = "",
                            Name = "Tłumik wiolonczelowy",
                            ProductCategoryId = 3
                        },
                        new
                        {
                            Id = 9,
                            DefaultPrice = 114.99m,
                            Description = "",
                            Name = "Tłumik do trąbki C",
                            ProductCategoryId = 3
                        },
                        new
                        {
                            Id = 10,
                            DefaultPrice = 108.9m,
                            Description = "",
                            Name = "Pulpit srebrny",
                            ProductCategoryId = 4
                        },
                        new
                        {
                            Id = 11,
                            DefaultPrice = 190.99m,
                            Description = "",
                            Name = "Pulpit koncertowy - czarny",
                            ProductCategoryId = 4
                        },
                        new
                        {
                            Id = 12,
                            DefaultPrice = 349.9m,
                            Description = "",
                            Name = "Pulpit Dyrygencki",
                            ProductCategoryId = 4
                        });
                });

            modelBuilder.Entity("SafeBook.Domain.Shop.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Kubki z nadrukiem, muzyczne i inne",
                            Name = "Kubki"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ołówki, długopisy muzyczne i inne",
                            Name = "Artykuły biurowe"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Akcesoria do instrumentów smyczkowych i dętych",
                            Name = "Akcesoria do instrumentów"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Inne akcesoria, pulpity, lampki i pozostałe",
                            Name = "Akcesoria muzyczne"
                        });
                });

            modelBuilder.Entity("SafeBook.Domain.Common.User", b =>
                {
                    b.HasOne("SafeBook.Domain.Common.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SafeBook.Domain.Shop.Product", b =>
                {
                    b.HasOne("SafeBook.Domain.Shop.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("SafeBook.Domain.Common.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SafeBook.Domain.Shop.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}