using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patient_Registration_System.Migrations
{
    /// <inheritdoc />
    public partial class Seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "saveUsers",
                columns: new[] { "SaveId", "_userName" },
                values: new object[] { 1, "save" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "saveUsers",
                keyColumn: "SaveId",
                keyValue: 1);
        }
    }
}
