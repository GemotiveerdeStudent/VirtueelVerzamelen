using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtueelVerzamelen.Migrations
{
    /// <inheritdoc />
    public partial class AddClasNameToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Collections",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Collections");
        }
    }
}
