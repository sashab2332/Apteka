using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Apteka.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: false),
                    Cuantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellings",
                columns: table => new
                {
                    SellingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellings", x => x.SellingId);
                    table.ForeignKey(
                        name: "FK_Sellings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SellingContents",
                columns: table => new
                {
                    SellingContentsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SCName = table.Column<string>(nullable: false),
                    SellingId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ItemAmmaunt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingContents", x => x.SellingContentsId);
                    table.ForeignKey(
                        name: "FK_SellingContents_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SellingContents_Sellings_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Sellings",
                        principalColumn: "SellingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_Id",
                table: "Items",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SellingContents_ItemId",
                table: "SellingContents",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingContents_SellingContentsId",
                table: "SellingContents",
                column: "SellingContentsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SellingContents_SellingId",
                table: "SellingContents",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellings_EmployeeId",
                table: "Sellings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellings_SellingId",
                table: "Sellings",
                column: "SellingId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellingContents");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Sellings");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
