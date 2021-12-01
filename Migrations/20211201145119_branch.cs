using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class branch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Branchs",
                table: "Branchs");

            migrationBuilder.RenameTable(
                name: "Branchs",
                newName: "Branch");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "Branchs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branchs",
                table: "Branchs",
                column: "Id");
        }
    }
}
