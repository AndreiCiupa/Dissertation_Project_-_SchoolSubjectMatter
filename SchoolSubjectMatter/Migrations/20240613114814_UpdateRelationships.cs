using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolSubjectMatter.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Student_StudentsId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Subject_SubjectsId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTeacher_Subject_SubjectsId",
                table: "SubjectTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTeacher_Teacher_TeachersId",
                table: "SubjectTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectTeacher",
                table: "SubjectTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject");

            migrationBuilder.RenameTable(
                name: "SubjectTeacher",
                newName: "TeacherSubjects");

            migrationBuilder.RenameTable(
                name: "StudentSubject",
                newName: "StudentSubjects");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectTeacher_TeachersId",
                table: "TeacherSubjects",
                newName: "IX_TeacherSubjects_TeachersId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubject_SubjectsId",
                table: "StudentSubjects",
                newName: "IX_StudentSubjects_SubjectsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherSubjects",
                table: "TeacherSubjects",
                columns: new[] { "SubjectsId", "TeachersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubjects",
                table: "StudentSubjects",
                columns: new[] { "StudentsId", "SubjectsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Student_StudentsId",
                table: "StudentSubjects",
                column: "StudentsId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subject_SubjectsId",
                table: "StudentSubjects",
                column: "SubjectsId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSubjects_Subject_SubjectsId",
                table: "TeacherSubjects",
                column: "SubjectsId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSubjects_Teacher_TeachersId",
                table: "TeacherSubjects",
                column: "TeachersId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Student_StudentsId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subject_SubjectsId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSubjects_Subject_SubjectsId",
                table: "TeacherSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSubjects_Teacher_TeachersId",
                table: "TeacherSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherSubjects",
                table: "TeacherSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubjects",
                table: "StudentSubjects");

            migrationBuilder.RenameTable(
                name: "TeacherSubjects",
                newName: "SubjectTeacher");

            migrationBuilder.RenameTable(
                name: "StudentSubjects",
                newName: "StudentSubject");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherSubjects_TeachersId",
                table: "SubjectTeacher",
                newName: "IX_SubjectTeacher_TeachersId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubjects_SubjectsId",
                table: "StudentSubject",
                newName: "IX_StudentSubject_SubjectsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectTeacher",
                table: "SubjectTeacher",
                columns: new[] { "SubjectsId", "TeachersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject",
                columns: new[] { "StudentsId", "SubjectsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Student_StudentsId",
                table: "StudentSubject",
                column: "StudentsId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Subject_SubjectsId",
                table: "StudentSubject",
                column: "SubjectsId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTeacher_Subject_SubjectsId",
                table: "SubjectTeacher",
                column: "SubjectsId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTeacher_Teacher_TeachersId",
                table: "SubjectTeacher",
                column: "TeachersId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
