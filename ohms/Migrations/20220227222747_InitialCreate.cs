using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ohms.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ohmsClass",
                table: "ohmsClass");

            migrationBuilder.RenameTable(
                name: "ohmsClass",
                newName: "ohms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ohms",
                table: "ohms",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ohms",
                table: "ohms");

            migrationBuilder.RenameTable(
                name: "ohms",
                newName: "ohmsClass");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ohmsClass",
                table: "ohmsClass",
                column: "Id");
        }
    }
}
