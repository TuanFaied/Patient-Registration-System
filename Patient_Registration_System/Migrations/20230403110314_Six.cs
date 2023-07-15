using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patient_Registration_System.Migrations
{
    /// <inheritdoc />
    public partial class Six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_password",
                table: "saveUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_password",
                table: "saveUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
