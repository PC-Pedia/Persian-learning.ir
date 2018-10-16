using Microsoft.EntityFrameworkCore.Migrations;

namespace PesianLearning.Data.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Courses_CourseID",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Images",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Courses_CourseID",
                table: "Images",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Courses_CourseID",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Images",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Courses_CourseID",
                table: "Images",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
