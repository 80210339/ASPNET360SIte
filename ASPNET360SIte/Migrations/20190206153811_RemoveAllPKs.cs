using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET360SIte.Migrations
{
    public partial class RemoveAllPKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FloorPlan_Room_RoomID",
                table: "FloorPlan");

            migrationBuilder.DropIndex(
                name: "IX_FloorPlan_RoomID",
                table: "FloorPlan");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "FloorPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "FloorPlan",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
