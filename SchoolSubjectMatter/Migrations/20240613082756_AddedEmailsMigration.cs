using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolSubjectMatter.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Teacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_StudentId",
                table: "Teacher",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Student_StudentId",
                table: "Teacher",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Student_StudentId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_StudentId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Student");
        }
    }
}
