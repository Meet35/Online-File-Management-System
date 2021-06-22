using Microsoft.EntityFrameworkCore.Migrations;

namespace fms.Migrations
{
    public partial class tableshare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "share",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    owneremail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fileid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collaboratoremail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_share", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "share");
        }
    }
}
