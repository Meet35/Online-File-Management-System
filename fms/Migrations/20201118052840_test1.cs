using Microsoft.EntityFrameworkCore.Migrations;

namespace fms.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_test",
                table: "test");

            migrationBuilder.RenameTable(
                name: "test",
                newName: "share");

            migrationBuilder.AddPrimaryKey(
                name: "PK_share",
                table: "share",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_share",
                table: "share");

            migrationBuilder.RenameTable(
                name: "share",
                newName: "test");

            migrationBuilder.AddPrimaryKey(
                name: "PK_test",
                table: "test",
                column: "Id");
        }
    }
}
