using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.CRUD.Migrations
{
    /// <inheritdoc />
    public partial class userTableWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Password", "PhoneNumber", "ProfilePicture", "Role", "Salary", "State", "Username", "ZipCode" },
                values: new object[,]
                {
                    { 1, "10 Main St", "City1", new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", "First1", "Female", "Last1", "P@ssword1", "555-00001", "profile1.jpg", "User", 31000.0, "State1", "user1", "10001" },
                    { 2, "20 Main St", "City2", new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", "First2", "Male", "Last2", "P@ssword2", "555-00002", "profile2.jpg", "User", 32000.0, "State2", "user2", "10002" },
                    { 3, "30 Main St", "City3", new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", "First3", "Female", "Last3", "P@ssword3", "555-00003", "profile3.jpg", "Admin", 33000.0, "State3", "user3", "10003" },
                    { 4, "40 Main St", "City4", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", "First4", "Male", "Last4", "P@ssword4", "555-00004", "profile4.jpg", "User", 34000.0, "State4", "user4", "10004" },
                    { 5, "50 Main St", "City5", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", "First5", "Female", "Last5", "P@ssword5", "555-00005", "profile5.jpg", "User", 35000.0, "State5", "user5", "10005" },
                    { 6, "60 Main St", "City6", new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", "First6", "Male", "Last6", "P@ssword6", "555-00006", "profile6.jpg", "Admin", 36000.0, "State6", "user6", "10006" },
                    { 7, "70 Main St", "City7", new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", "First7", "Female", "Last7", "P@ssword7", "555-00007", "profile7.jpg", "User", 37000.0, "State7", "user7", "10007" },
                    { 8, "80 Main St", "City8", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", "First8", "Male", "Last8", "P@ssword8", "555-00008", "profile8.jpg", "User", 38000.0, "State8", "user8", "10008" },
                    { 9, "90 Main St", "City9", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", "First9", "Female", "Last9", "P@ssword9", "555-00009", "profile9.jpg", "Admin", 39000.0, "State9", "user9", "10009" },
                    { 10, "100 Main St", "City10", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", "First10", "Male", "Last10", "P@ssword10", "555-00010", "profile10.jpg", "User", 40000.0, "State10", "user10", "10010" },
                    { 11, "110 Main St", "City11", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", "First11", "Female", "Last11", "P@ssword11", "555-00011", "profile11.jpg", "User", 41000.0, "State11", "user11", "10011" },
                    { 12, "120 Main St", "City12", new DateTime(1978, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", "First12", "Male", "Last12", "P@ssword12", "555-00012", "profile12.jpg", "Admin", 42000.0, "State12", "user12", "10012" },
                    { 13, "130 Main St", "City13", new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user13@example.com", "First13", "Female", "Last13", "P@ssword13", "555-00013", "profile13.jpg", "User", 43000.0, "State13", "user13", "10013" },
                    { 14, "140 Main St", "City14", new DateTime(1976, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user14@example.com", "First14", "Male", "Last14", "P@ssword14", "555-00014", "profile14.jpg", "User", 44000.0, "State14", "user14", "10014" },
                    { 15, "150 Main St", "City15", new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user15@example.com", "First15", "Female", "Last15", "P@ssword15", "555-00015", "profile15.jpg", "Admin", 45000.0, "State15", "user15", "10015" },
                    { 16, "160 Main St", "City16", new DateTime(1974, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user16@example.com", "First16", "Male", "Last16", "P@ssword16", "555-00016", "profile16.jpg", "User", 46000.0, "State16", "user16", "10016" },
                    { 17, "170 Main St", "City17", new DateTime(1973, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user17@example.com", "First17", "Female", "Last17", "P@ssword17", "555-00017", "profile17.jpg", "User", 47000.0, "State17", "user17", "10017" },
                    { 18, "180 Main St", "City18", new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user18@example.com", "First18", "Male", "Last18", "P@ssword18", "555-00018", "profile18.jpg", "Admin", 48000.0, "State18", "user18", "10018" },
                    { 19, "190 Main St", "City19", new DateTime(1971, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user19@example.com", "First19", "Female", "Last19", "P@ssword19", "555-00019", "profile19.jpg", "User", 49000.0, "State19", "user19", "10019" },
                    { 20, "200 Main St", "City20", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user20@example.com", "First20", "Male", "Last20", "P@ssword20", "555-00020", "profile20.jpg", "User", 50000.0, "State20", "user20", "10020" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
