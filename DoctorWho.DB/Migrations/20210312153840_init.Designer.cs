// <auto-generated />
using System;
using DoctorWho.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorWho.DB.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20210312153840_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorWho.DB.Models.TblAuthor", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("TblAuthors");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblCompanion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("TblCompanions");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblDoctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("TblDoctors");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEnemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("TblEnemies");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EpisodeDatedate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("TblEpisodes");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int?>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("TblEpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int?>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("TblEpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisode", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.TblAuthor", "Author")
                        .WithMany("TblEpisodes")
                        .HasForeignKey("AuthorId");

                    b.HasOne("DoctorWho.DB.Models.TblDoctor", "Doctor")
                        .WithMany("TblEpisodes")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.TblCompanion", "Companion")
                        .WithMany("TblEpisodeCompanions")
                        .HasForeignKey("CompanionId");

                    b.HasOne("DoctorWho.DB.Models.TblEpisode", "Episode")
                        .WithMany("TblEpisodeCompanions")
                        .HasForeignKey("EpisodeId");

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.TblEnemy", "Enemy")
                        .WithMany("TblEpisodeEnemies")
                        .HasForeignKey("EnemyId");

                    b.HasOne("DoctorWho.DB.Models.TblEpisode", "Episode")
                        .WithMany("TblEpisodeEnemies")
                        .HasForeignKey("EpisodeId");

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblAuthor", b =>
                {
                    b.Navigation("TblEpisodes");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblCompanion", b =>
                {
                    b.Navigation("TblEpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblDoctor", b =>
                {
                    b.Navigation("TblEpisodes");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEnemy", b =>
                {
                    b.Navigation("TblEpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.TblEpisode", b =>
                {
                    b.Navigation("TblEpisodeCompanions");

                    b.Navigation("TblEpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
