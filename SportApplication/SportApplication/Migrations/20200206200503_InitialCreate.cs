using Microsoft.EntityFrameworkCore.Migrations;

namespace SportApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contestants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contestants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<int>(nullable: false),
                    SportTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ContestantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                    table.ForeignKey(
                        name: "FK_Sports_Contestants_ContestantID",
                        column: x => x.ContestantID,
                        principalTable: "Contestants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportID = table.Column<int>(nullable: false),
                    ContestantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_Enrollments_Contestants_ContestantID",
                        column: x => x.ContestantID,
                        principalTable: "Contestants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ContestantID",
                table: "Enrollments",
                column: "ContestantID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SportID",
                table: "Enrollments",
                column: "SportID");

            migrationBuilder.CreateIndex(
                name: "IX_Sports_ContestantID",
                table: "Sports",
                column: "ContestantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Contestants");
        }
    }
}
