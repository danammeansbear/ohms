using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ohms.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ohmsClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAL = table.Column<int>(type: "int", nullable: false),
                    SigFig = table.Column<int>(type: "int", nullable: false),
                    Multiplier = table.Column<long>(type: "bigint", nullable: false),
                    Multiplier2 = table.Column<long>(type: "bigint", nullable: false),
                    Percent = table.Column<double>(type: "float", nullable: false),
                    Letter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ppmk = table.Column<long>(type: "bigint", nullable: false),
                    TCLetter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ohmsClass", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ohmsClass");
        }
    }
}
