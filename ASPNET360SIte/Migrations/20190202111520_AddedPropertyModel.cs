using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET360SIte.Migrations
{
    public partial class AddedPropertyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Build = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Locality = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(maxLength: 10, nullable: true),
                    MainImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FloorPlan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FloorPlanLabel = table.Column<string>(nullable: true),
                    MainImagePath = table.Column<string>(nullable: true),
                    PropertyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorPlan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FloorPlan_Property_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Property",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomLabel = table.Column<string>(nullable: true),
                    MainImagePath = table.Column<string>(nullable: true),
                    FloorPlanID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Room_FloorPlan_FloorPlanID",
                        column: x => x.FloorPlanID,
                        principalTable: "FloorPlan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FloorPlan_PropertyID",
                table: "FloorPlan",
                column: "PropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_FloorPlanID",
                table: "Room",
                column: "FloorPlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "FloorPlan");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
