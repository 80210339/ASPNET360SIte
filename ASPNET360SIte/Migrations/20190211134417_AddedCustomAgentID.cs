using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET360SIte.Migrations
{
    public partial class AddedCustomAgentID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomAgentID",
                table: "Property",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomAgentID",
                table: "Property");
        }
    }
}
