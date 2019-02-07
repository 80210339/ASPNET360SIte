using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET360SIte.Migrations
{
    public partial class removeAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FloorPlan_Room_RoomID",
                table: "FloorPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_FloorPlan_FloorPlanID",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_FloorPlanID",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_FloorPlan_RoomID",
                table: "FloorPlan");

            migrationBuilder.DropColumn(
                name: "FloorPlanID",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "FloorPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FloorPlanID",
                table: "Property",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "FloorPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Property_FloorPlanID",
                table: "Property",
                column: "FloorPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_FloorPlan_RoomID",
                table: "FloorPlan",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_FloorPlan_Room_RoomID",
                table: "FloorPlan",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_FloorPlan_FloorPlanID",
                table: "Property",
                column: "FloorPlanID",
                principalTable: "FloorPlan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
