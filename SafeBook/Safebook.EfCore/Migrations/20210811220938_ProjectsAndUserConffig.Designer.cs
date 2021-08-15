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
    [Migration("20210811220938_ProjectsAndUserConffig")]
    partial class ProjectsAndUserConffig
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdressLine1 = "Krótka 4/56",
                            BirthDate = new DateTime(2021, 8, 12, 0, 9, 37, 610, DateTimeKind.Local).AddTicks(7269),
                            City = "Kraków",
                            FirstName = "Adam",
                            LastName = "Stary",
                            PostalCode = "30-004",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            AdressLine1 = "Długa 98/3",
                            BirthDate = new DateTime(2021, 8, 12, 0, 9, 37, 610, DateTimeKind.Local).AddTicks(9342),
                            City = "Poznań",
                            FirstName = "Magda",
                            LastName = "Młoda",
                            PostalCode = "23-323",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            AdressLine1 = "Lipna 10/5c",
                            BirthDate = new DateTime(2021, 8, 12, 0, 9, 37, 610, DateTimeKind.Local).AddTicks(9358),
                            City = "Kraków",
                            FirstName = "Lech",
                            LastName = "Nijaki",
                            PostalCode = "50-111",
                            RoleId = 3
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2021, 8, 12, 0, 9, 37, 605, DateTimeKind.Local).AddTicks(7334),
                            Description = "kolejny ładny projekt",
                            Title = "Taki fajny projekt"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2021, 8, 12, 0, 9, 37, 608, DateTimeKind.Local).AddTicks(8806),
                            Description = "dobrze kolega mówi, zacny",
                            Title = "A ten jaki ładny"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2021, 8, 12, 0, 9, 37, 608, DateTimeKind.Local).AddTicks(8897),
                            Description = "program ewidentnie im nie leżał",
                            Title = "No, ten to nie siadł"
                        });
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