using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.CRUD.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataEmployeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Department", "EntryDate", "JoinDate", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0a"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", 50000.0 },
                    { new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0b"), new DateTime(1985, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", new DateTime(2018, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", 60000.0 },
                    { new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0c"), new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", new DateTime(2015, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", 75000.0 },
                    { new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0d"), new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", 55000.0 },
                    { new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0e"), new DateTime(1988, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", new DateTime(2017, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve", 70000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d7009656-56b2-4b7a-b423-7a81c2b82f0e"));
        }
    }
}
