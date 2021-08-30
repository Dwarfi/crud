using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Employees",
                newName: "EmployeePosition");

            migrationBuilder.RenameColumn(
                name: "nvarchar(10)",
                table: "Employees",
                newName: "EmployeeCode");

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "nvarchar(250)");

            migrationBuilder.RenameColumn(
                name: "EmployeePosition",
                table: "Employees",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "EmployeeCode",
                table: "Employees",
                newName: "nvarchar(10)");
        }
    }
}
