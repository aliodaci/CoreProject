using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProject.DataAccessLayer.Migrations
{
    public partial class mig_notificationcolor_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Notifications");
        }
    }
}
