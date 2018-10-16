using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PesianLearning.Data.Migrations
{
    public partial class mok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Images_ImageID",
                table: "Sliders");

            migrationBuilder.DropTable(
                name: "MinorTopic");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Sliders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Sliders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfID",
                table: "Sliders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfID",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hedings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TopicID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hedings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hedings_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_CourseID",
                table: "Sliders",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_ProfID",
                table: "Sliders",
                column: "ProfID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProfID",
                table: "Images",
                column: "ProfID",
                unique: true,
                filter: "[ProfID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Hedings_TopicID",
                table: "Hedings",
                column: "TopicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Professors_ProfID",
                table: "Images",
                column: "ProfID",
                principalTable: "Professors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Courses_CourseID",
                table: "Sliders",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Images_ImageID",
                table: "Sliders",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Professors_ProfID",
                table: "Sliders",
                column: "ProfID",
                principalTable: "Professors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Professors_ProfID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Courses_CourseID",
                table: "Sliders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Images_ImageID",
                table: "Sliders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Professors_ProfID",
                table: "Sliders");

            migrationBuilder.DropTable(
                name: "Hedings");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_CourseID",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_ProfID",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProfID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "ProfID",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "ProfID",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Sliders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MinorTopic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeTopic = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    TopicID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinorTopic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MinorTopic_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MinorTopic_TopicID",
                table: "MinorTopic",
                column: "TopicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Images_ImageID",
                table: "Sliders",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
