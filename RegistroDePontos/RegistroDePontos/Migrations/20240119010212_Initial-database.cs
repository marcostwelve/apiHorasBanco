using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroDePontos.Migrations
{
    public partial class Initialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntradaExpediente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntradaAlmoco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoltaAlmoco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaidaExpediente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
