using Microsoft.EntityFrameworkCore;
using MVC.CRUD.Models;

namespace MVC.CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                   Id = Guid.Parse("d7009656-56b2-4b7a-b423-7a81c2b82f0a"),
                   Name = "Alice",
                   Salary = 50000.00,
                   DateOfBirth = new DateTime(1990, 5, 15),
                   Department = "Engineering",
                   JoinDate = new DateTime(2020, 1, 10),
                   EntryDate = new DateTime(2020, 1, 5)
                },
                new Employee
                {
                    Id = Guid.Parse("d7009656-56b2-4b7a-b423-7a81c2b82f0b"),
                    Name = "Bob",
                    Salary = 60000.00,
                    DateOfBirth = new DateTime(1985, 11, 20),
                    Department = "Marketing",
                    JoinDate = new DateTime(2018, 7, 22),
                    EntryDate = new DateTime(2018, 7, 15)
                },
                new Employee
                {
                    Id = Guid.Parse("d7009656-56b2-4b7a-b423-7a81c2b82f0c"),
                    Name = "Charlie",
                    Salary = 75000.00,
                    DateOfBirth = new DateTime(1982, 3, 10),
                    Department = "Finance",
                    JoinDate = new DateTime(2015, 9, 30),
                    EntryDate = new DateTime(2015, 9, 25)
                },
                new Employee
                {
                    Id = Guid.Parse("d7009656-56b2-4b7a-b423-7a81c2b82f0d"),
                    Name = "David",
                    Salary = 55000.00,
                    DateOfBirth = new DateTime(1995, 8, 5),
                    Department = "Human Resources",
                    JoinDate = new DateTime(2019, 3, 18),
                    EntryDate = new DateTime(2019, 3, 12)
                },
                new Employee
                {
                    Id = Guid.Parse("d7009656-56b2-4b7a-b423-7a81c2b82f0e"),
                    Name = "Eve",
                    Salary = 70000.00,
                    DateOfBirth = new DateTime(1988, 1, 25),
                    Department = "Sales",
                    JoinDate = new DateTime(2017, 11, 14),
                    EntryDate = new DateTime(2017, 11, 8)
                } 
            );          
        }
        public DbSet<MVC.CRUD.Models.User> User_1 { get; set; } = default!;
    }
}
