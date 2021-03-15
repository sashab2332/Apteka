using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Apteka.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees1",
                columns: table => new
                {
                    EmployeeId1 = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name1 = table.Column<string>(nullable: false),
                    Login1 = table.Column<string>(nullable: false),
                    Password1 = table.Column<string>(nullable: false),
                    Position1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees1", x => x.EmployeeId1);
                });

            migrationBuilder.CreateTable(
                name: "Items1",
                columns: table => new
                {
                    Id1 = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName1 = table.Column<string>(nullable: false),
                    Cuantity1 = table.Column<int>(nullable: false),
                    Price1 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items1", x => x.Id1);
                });

            migrationBuilder.CreateTable(
                name: "Sellings1",
                columns: table => new
                {
                    SellingId1 = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime1 = table.Column<DateTime>(nullable: false),
                    Price1 = table.Column<double>(nullable: false),
                    EmployeeId1 = table.Column<int>(nullable: false),
                    AEmployee1EmployeeId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellings1", x => x.SellingId1);
                    table.ForeignKey(
                        name: "FK_Sellings1_Employees1_AEmployee1EmployeeId1",
                        column: x => x.AEmployee1EmployeeId1,
                        principalTable: "Employees1",
                        principalColumn: "EmployeeId1",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingContents1",
                columns: table => new
                {
                    SellingContentsId1 = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SCName1 = table.Column<string>(nullable: false),
                    SellingId1 = table.Column<int>(nullable: false),
                    ASelling1SellingId1 = table.Column<int>(nullable: true),
                    ItemId1 = table.Column<int>(nullable: false),
                    AItem1Id1 = table.Column<int>(nullable: true),
                    Price1 = table.Column<double>(nullable: false),
                    ItemAmmaunt1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingContents1", x => x.SellingContentsId1);
                    table.ForeignKey(
                        name: "FK_SellingContents1_Items1_AItem1Id1",
                        column: x => x.AItem1Id1,
                        principalTable: "Items1",
                        principalColumn: "Id1",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingContents1_Sellings1_ASelling1SellingId1",
                        column: x => x.ASelling1SellingId1,
                        principalTable: "Sellings1",
                        principalColumn: "SellingId1",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees1_EmployeeId1",
                table: "Employees1",
                column: "EmployeeId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items1_Id1",
                table: "Items1",
                column: "Id1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SellingContents1_AItem1Id1",
                table: "SellingContents1",
                column: "AItem1Id1");

            migrationBuilder.CreateIndex(
                name: "IX_SellingContents1_ASelling1SellingId1",
                table: "SellingContents1",
                column: "ASelling1SellingId1");

            migrationBuilder.CreateIndex(
                name: "IX_SellingContents1_SellingContentsId1",
                table: "SellingContents1",
                column: "SellingContentsId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sellings1_AEmployee1EmployeeId1",
                table: "Sellings1",
                column: "AEmployee1EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Sellings1_SellingId1",
                table: "Sellings1",
                column: "SellingId1",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellingContents1");

            migrationBuilder.DropTable(
                name: "Items1");

            migrationBuilder.DropTable(
                name: "Sellings1");

            migrationBuilder.DropTable(
                name: "Employees1");
        }
    }
}
