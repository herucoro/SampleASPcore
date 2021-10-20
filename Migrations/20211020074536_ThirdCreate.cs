using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "toner_id",
                table: "printer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "toner_id",
                table: "printer",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
