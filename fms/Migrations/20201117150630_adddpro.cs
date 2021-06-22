using Microsoft.EntityFrameworkCore.Migrations;

namespace fms.Migrations
{
    public partial class adddpro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filepath",
                table: "share",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filepath",
                table: "share");
        }
    }
}
