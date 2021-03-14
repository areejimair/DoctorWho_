using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.DB.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblAuthors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Author1" },
                    { 2, "Author2" },
                    { 3, "Author3" },
                    { 4, "Author4" },
                    { 5, "Author5" }
                });

            migrationBuilder.InsertData(
                table: "TblCompanions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 4, "Name4", "palyer4" },
                    { 3, "Name3", "palyer3" },
                    { 5, "Name5", "palyer5" },
                    { 1, "Name1", "palyer1" },
                    { 2, "Name2", "palyer2" }
                });

            migrationBuilder.InsertData(
                table: "TblDoctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor1", 1, new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor2", 2, new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor3", 3, new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor4", 4, new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor5", 5, new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TblEnemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 4, "Des4", "Name4" },
                    { 1, "Des1", "Name1" },
                    { 2, "Des2", "Name2" },
                    { 3, "Des3", "Name3" },
                    { 5, "Des5", "Name5" }
                });

            migrationBuilder.InsertData(
                table: "TblEpisodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDatedate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "comedey", "Funny", 2, "Brooklyn99" },
                    { 2, 2, 2, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "comedey", "Funny", 2, "Brooklyn99" },
                    { 3, 3, 3, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "comedey", "Funny", 2, "Brooklyn99" },
                    { 4, 4, 4, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "comedey", "Funny", 2, "Brooklyn99" },
                    { 5, 5, 5, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "comedey", "Funny", 2, "Brooklyn99" }
                });

            migrationBuilder.InsertData(
                table: "TblEpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "TblEpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblEpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblEpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblEpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblEpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblEpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblEpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblEpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblEpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblEpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblEpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblCompanions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblCompanions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblCompanions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblCompanions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblCompanions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblEnemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblEnemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblEnemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblEnemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblEnemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblEpisodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblEpisodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblEpisodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblEpisodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblEpisodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblAuthors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblAuthors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblAuthors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblAuthors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblAuthors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblDoctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblDoctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblDoctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblDoctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblDoctors",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
