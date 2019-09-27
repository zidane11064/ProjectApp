using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.API.Migrations
{
    public partial class updatedDBcorrectError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Introduciton",
                table: "Users",
                newName: "Introduction");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Introduction",
                table: "Users",
                newName: "Introduciton");
        }
    }
}
