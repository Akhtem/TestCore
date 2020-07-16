using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Migrations
{
    public partial class CreateCourseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DayOfWeek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOfWeek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeOfDay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Time = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOfDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    CourseId = table.Column<int>(nullable: false),
                    DayOfWeekId = table.Column<int>(nullable: false),
                    TimeOfDayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseInfos_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseInfos_DayOfWeek_DayOfWeekId",
                        column: x => x.DayOfWeekId,
                        principalTable: "DayOfWeek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CourseInfos_TimeOfDay_TimeOfDayId",
                        column: x => x.TimeOfDayId,
                        principalTable: "TimeOfDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInfos_CourseId",
                table: "CourseInfos",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInfos_DayOfWeekId",
                table: "CourseInfos",
                column: "DayOfWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInfos_TimeOfDayId",
                table: "CourseInfos",
                column: "TimeOfDayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInfos");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "DayOfWeek");

            migrationBuilder.DropTable(
                name: "TimeOfDay");
        }
    }
}
