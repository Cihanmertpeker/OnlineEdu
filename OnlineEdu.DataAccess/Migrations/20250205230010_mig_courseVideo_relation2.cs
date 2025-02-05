using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineEdu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_courseVideo_relation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseVideo_Courses_CourseId",
                table: "CourseVideo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseVideo",
                table: "CourseVideo");

            migrationBuilder.RenameTable(
                name: "CourseVideo",
                newName: "CourseVideos");

            migrationBuilder.RenameIndex(
                name: "IX_CourseVideo_CourseId",
                table: "CourseVideos",
                newName: "IX_CourseVideos_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseVideos",
                table: "CourseVideos",
                column: "CourseVideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseVideos_Courses_CourseId",
                table: "CourseVideos",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseVideos_Courses_CourseId",
                table: "CourseVideos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseVideos",
                table: "CourseVideos");

            migrationBuilder.RenameTable(
                name: "CourseVideos",
                newName: "CourseVideo");

            migrationBuilder.RenameIndex(
                name: "IX_CourseVideos_CourseId",
                table: "CourseVideo",
                newName: "IX_CourseVideo_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseVideo",
                table: "CourseVideo",
                column: "CourseVideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseVideo_Courses_CourseId",
                table: "CourseVideo",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
