using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCV.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Table_Column_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShcoolName",
                table: "Educations",
                newName: "SchoolName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SchoolName",
                table: "Educations",
                newName: "ShcoolName");
        }
    }
}
