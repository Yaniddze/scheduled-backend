using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class AddNewEntities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubject_Groups_GroupId",
                table: "GroupSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubject_Subject_SubjectId",
                table: "GroupSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupSubject",
                table: "GroupSubject");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "GroupSubject",
                newName: "GroupSubjects");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_TeacherId",
                table: "Subjects",
                newName: "IX_Subjects_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubject_SubjectId",
                table: "GroupSubjects",
                newName: "IX_GroupSubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubject_GroupId",
                table: "GroupSubjects",
                newName: "IX_GroupSubjects_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupSubjects",
                table: "GroupSubjects",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubjects_Groups_GroupId",
                table: "GroupSubjects",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubjects_Subjects_SubjectId",
                table: "GroupSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubjects_Groups_GroupId",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSubjects_Subjects_SubjectId",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupSubjects",
                table: "GroupSubjects");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "GroupSubjects",
                newName: "GroupSubject");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subject",
                newName: "IX_Subject_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubjects_SubjectId",
                table: "GroupSubject",
                newName: "IX_GroupSubject_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSubjects_GroupId",
                table: "GroupSubject",
                newName: "IX_GroupSubject_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupSubject",
                table: "GroupSubject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubject_Groups_GroupId",
                table: "GroupSubject",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSubject_Subject_SubjectId",
                table: "GroupSubject",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
