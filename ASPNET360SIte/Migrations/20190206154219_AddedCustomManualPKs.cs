using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET360SIte.Migrations
{
    public partial class AddedCustomManualPKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomFloorPlanID",
                table: "Room",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomPropertyID",
                table: "FloorPlan",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomFloorPlanID",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CustomPropertyID",
                table: "FloorPlan");
        }
    }
}
