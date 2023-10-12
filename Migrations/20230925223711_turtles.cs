using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropKeeperApi.Migrations
{
    /// <inheritdoc />
    public partial class turtles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayImageUrl",
                table: "Users");
        }
    }
}
