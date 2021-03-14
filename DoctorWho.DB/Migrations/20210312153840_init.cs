using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.DB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAuthors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAuthors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "TblCompanions",
                columns: table => new
                {
                    CompanionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoPlayed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCompanions", x => x.CompanionId);
                });

            migrationBuilder.CreateTable(
                name: "TblDoctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorNumber = table.Column<int>(type: "int", nullable: true),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstEpisodeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEpisodeDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDoctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "TblEnemies",
                columns: table => new
                {
                    EnemyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnemyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEnemies", x => x.EnemyId);
                });

            migrationBuilder.CreateTable(
                name: "TblEpisodes",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesNumber = table.Column<int>(type: "int", nullable: true),
                    EpisodeNumber = table.Column<int>(type: "int", nullable: true),
                    EpisodeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpisodeDatedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEpisodes", x => x.EpisodeId);
                    table.ForeignKey(
                        name: "FK_TblEpisodes_TblAuthors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "TblAuthors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEpisodes_TblDoctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "TblDoctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblEpisodeCompanions",
                columns: table => new
                {
                    EpisodeCompanionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpisodeId = table.Column<int>(type: "int", nullable: true),
                    CompanionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEpisodeCompanions", x => x.EpisodeCompanionId);
                    table.ForeignKey(
                        name: "FK_TblEpisodeCompanions_TblCompanions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "TblCompanions",
                        principalColumn: "CompanionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEpisodeCompanions_TblEpisodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "TblEpisodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblEpisodeEnemies",
                columns: table => new
                {
                    EpisodeEnemyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpisodeId = table.Column<int>(type: "int", nullable: true),
                    EnemyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEpisodeEnemies", x => x.EpisodeEnemyId);
                    table.ForeignKey(
                        name: "FK_TblEpisodeEnemies_TblEnemies_EnemyId",
                        column: x => x.EnemyId,
                        principalTable: "TblEnemies",
                        principalColumn: "EnemyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEpisodeEnemies_TblEpisodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "TblEpisodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblEpisodeCompanions_CompanionId",
                table: "TblEpisodeCompanions",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEpisodeCompanions_EpisodeId",
                table: "TblEpisodeCompanions",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEpisodeEnemies_EnemyId",
                table: "TblEpisodeEnemies",
                column: "EnemyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEpisodeEnemies_EpisodeId",
                table: "TblEpisodeEnemies",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEpisodes_AuthorId",
                table: "TblEpisodes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEpisodes_DoctorId",
                table: "TblEpisodes",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblEpisodeCompanions");

            migrationBuilder.DropTable(
                name: "TblEpisodeEnemies");

            migrationBuilder.DropTable(
                name: "TblCompanions");

            migrationBuilder.DropTable(
                name: "TblEnemies");

            migrationBuilder.DropTable(
                name: "TblEpisodes");

            migrationBuilder.DropTable(
                name: "TblAuthors");

            migrationBuilder.DropTable(
                name: "TblDoctors");
        }
    }
}
