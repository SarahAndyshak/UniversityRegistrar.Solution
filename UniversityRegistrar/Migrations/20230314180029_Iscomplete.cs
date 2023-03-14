using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityRegistrar.Migrations
{
    public partial class Iscomplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartment_Courses_CourseId",
                table: "CourseDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartment_Department_DepartmentId",
                table: "CourseDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDepartment",
                table: "CourseDepartment");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "CourseDepartment",
                newName: "CourseDepartments");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDepartment_DepartmentId",
                table: "CourseDepartments",
                newName: "IX_CourseDepartments_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDepartment_CourseId",
                table: "CourseDepartments",
                newName: "IX_CourseDepartments_CourseId");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "Courses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDepartments",
                table: "CourseDepartments",
                column: "CourseDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDepartments_Courses_CourseId",
                table: "CourseDepartments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDepartments_Departments_DepartmentId",
                table: "CourseDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartments_Courses_CourseId",
                table: "CourseDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartments_Departments_DepartmentId",
                table: "CourseDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDepartments",
                table: "CourseDepartments");

            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "CourseDepartments",
                newName: "CourseDepartment");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDepartments_DepartmentId",
                table: "CourseDepartment",
                newName: "IX_CourseDepartment_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDepartments_CourseId",
                table: "CourseDepartment",
                newName: "IX_CourseDepartment_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDepartment",
                table: "CourseDepartment",
                column: "CourseDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDepartment_Courses_CourseId",
                table: "CourseDepartment",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDepartment_Department_DepartmentId",
                table: "CourseDepartment",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
