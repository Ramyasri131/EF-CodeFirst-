using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDirectory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class adddescriptionfieldindatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Description",
                table: "Departments",
                column: "Description",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_Description",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Departments");
        }
    }
}
