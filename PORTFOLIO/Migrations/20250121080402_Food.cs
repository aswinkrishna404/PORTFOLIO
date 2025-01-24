using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PORTFOLIO.Migrations
{
    /// <inheritdoc />
    public partial class Food : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProjectList",
                columns: new[] { "Id", "Description", "Link", "Name" },
                values: new object[] { 1, "Description", "#", "website" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectList",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
