using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccountNumber", "Age", "Name" },
                values: new object[] { new Guid("8f000503-4a87-48a2-889d-185e36284023"), "123-3452134543-32", 30, "Mark" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccountNumber", "Age", "Name" },
                values: new object[] { new Guid("72de4796-2c13-4e50-a1b7-fd44274abfda"), "123-9384613085-55", 28, "Evelin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
