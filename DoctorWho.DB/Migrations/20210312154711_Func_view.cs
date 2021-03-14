using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.DB.Migrations
{
    public partial class Func_view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                          @"CREATE FUNCTION fnCompanions(@Episode_Id int )
                RETURNS varchar(50)
                AS
                begin
                 DECLARE @result VARCHAR(50) 
                  SELECT
                		@result =C.CompanionName

                	FROM
                		TblEpisodeCompanions AS EC
                		INNER JOIN TblCompanions AS C ON EC.CompanionId = c.CompanionId
                	WHERE
                		EC.EpisodeId = @Episode_Id
                return @result
                end"
                                        );
            migrationBuilder.Sql(
               @"CREATE FUNCTION fnEnemies(@EpisodeId int)
                 RETURNS varchar(50)
                 AS
                 begin
	            declare @result varchar(50)

            	SELECT
            		@result =C.EnemyName		
            	FROM
            		TblEpisodeEnemies AS EC
            		INNER JOIN TblEnemies AS C ON EC.EnemyId = C.EnemyId
            	WHERE
            		EC.EpisodeId = @EpisodeId

            	 return @result
                 end");

            migrationBuilder.Sql(
            @"CREATE VIEW ViewEpisodes
             AS

              SELECT 
	          SeriesNumber,
	          EpisodeNumber,
	          Title,
	         a.AuthorName As AuthorName,
	          d.DoctorName As DoctorName,
	          dbo.fnCompanions(e.EpisodeId) AS Companions,
	         dbo.fnEnemies(e.EpisodeId) AS Enemies
             FROM
            	TblEpisodes AS e
	           INNER JOIN TblAuthors AS a ON a.AuthorId = e.AuthorId
	          INNER JOIN TblDoctors AS d on e.DoctorId = d.DoctorId
              ");

            migrationBuilder.Sql(
        @"CREATE PROCEDURE  spSummariseEpisodes
as
begin
SELECT CompanionName,
    COUNT(CompanionName) AS companion_freq
    FROM     TblCompanions
    GROUP BY CompanionName
    ORDER BY companion_freq DESC
    OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY

SELECT EnemyName,
    COUNT(EnemyName) AS Enemy_freq
    FROM     TblEnemies
    GROUP BY EnemyName
    ORDER BY Enemy_freq DESC
    OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY
	end  ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP Function fnCompanions ");
            migrationBuilder.Sql(@"DROP  Function fnEnemies");
            migrationBuilder.Sql(@"DROP VIEW ViewEpisodes");
            migrationBuilder.Sql(@"DROP PROCEDURE spSummariseEpisodes");
        }
    }
}
