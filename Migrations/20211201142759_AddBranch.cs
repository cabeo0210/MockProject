using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class AddBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SlotTable = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Address", "BranchName", "CreateDate", "Distance", "SlotTable" },
                values: new object[,]
                {
                    { 1, "60 D1", "Agency 1", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 2, "60 D2", "Agency 2", new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 3, "60 D3", "Agency 3", new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 4, "60 D4", "Agency 4", new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branchs");
        }
    }
}
