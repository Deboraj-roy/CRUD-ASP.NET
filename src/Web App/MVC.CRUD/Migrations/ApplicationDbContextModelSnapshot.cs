﻿// <auto-generated />
using System;
using MVC.CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.CRUD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC.CRUD.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0a"),
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Engineering",
                            EntryDate = new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice",
                            Salary = 50000.0
                        },
                        new
                        {
                            Id = new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0b"),
                            DateOfBirth = new DateTime(1985, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Marketing",
                            EntryDate = new DateTime(2018, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2018, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bob",
                            Salary = 60000.0
                        },
                        new
                        {
                            Id = new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0c"),
                            DateOfBirth = new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Finance",
                            EntryDate = new DateTime(2015, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2015, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Charlie",
                            Salary = 75000.0
                        },
                        new
                        {
                            Id = new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0d"),
                            DateOfBirth = new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Human Resources",
                            EntryDate = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "David",
                            Salary = 55000.0
                        },
                        new
                        {
                            Id = new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0e"),
                            DateOfBirth = new DateTime(1988, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Sales",
                            EntryDate = new DateTime(2017, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eve",
                            Salary = 70000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
