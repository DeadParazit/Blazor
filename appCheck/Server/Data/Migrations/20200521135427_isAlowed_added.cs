using Microsoft.EntityFrameworkCore.Migrations;

namespace appCheck.Server.Data.Migrations
{
    public partial class isAlowed_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAllowed",
                table: "Publications",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAllowed",
                table: "Publications");
        }
    }
}
