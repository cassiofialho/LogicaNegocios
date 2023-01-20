using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SegurancaIdentity.Data.Migrations
{
    public partial class MingrationInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrega",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destinatario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Produto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    DataEntrega = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrega", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrega");
        }
    }
}
