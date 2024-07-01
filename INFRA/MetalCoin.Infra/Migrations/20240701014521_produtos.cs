using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetalCoin.Infra.Migrations
{
    public partial class produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "preco",
                table: "Produtos",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "preco",
                table: "Produtos");
        }
    }
}
