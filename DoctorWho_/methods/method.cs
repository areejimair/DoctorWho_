using System;
using System.Linq;
using DoctorWho.DB;
using DoctorWho.DB.Models;
using Microsoft.EntityFrameworkCore;
namespace DoctorWho_.methods
{
    public class method

    {
       public DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
    public void  Create_Companios(string Compaion_Name,string Who_Played)
        {
            TblCompanion Createcompanion = new TblCompanion
           {
              
              CompanionName=Compaion_Name,
              WhoPlayed=Who_Played
           };
            context.Add(Createcompanion);
            context.SaveChanges();
        }
        public void Create_Enemy(string Enemy_Name, string Description)
        {
            TblEnemy CreateEnemy = new TblEnemy
            {

                EnemyName =Enemy_Name,
                Description= Description
            };
            context.Add(CreateEnemy);
            context.SaveChanges();
        }
        public void Create_Doctor(int Doctor_Number, string Doctor_Name,DateTime birth,DateTime FirstEpisode,DateTime LastEpisode)
        {
            TblDoctor CreateDoctor = new TblDoctor
            {
                DoctorNumber = Doctor_Number,
                DoctorName =Doctor_Name,
                BirthDate=birth,
                FirstEpisodeDate=FirstEpisode,
                LastEpisodeDate=LastEpisode
              

            };
            context.Add(CreateDoctor);
            context.SaveChanges();
        }
        public void Create_Author(string Author_Name)
        {
            TblAuthor CreateAuthor = new TblAuthor
            {
              AuthorName=Author_Name
            };
            context.Add(CreateAuthor);
            context.SaveChanges();
        }
        public void Create_Episode(int seriesNumber,int episodenumber,string episodeType,string title,DateTime episodeDate,int authorId,int doctorId,string notes)
        {
            TblEpisode CreateEpisode= new TblEpisode
            {
                SeriesNumber=seriesNumber,
                EpisodeNumber=episodenumber,
                EpisodeType=episodeType,
                Title=title,
                EpisodeDatedate=episodeDate,
                AuthorId=authorId,
                DoctorId=doctorId,
                Notes=notes

            };
            context.Add(CreateEpisode);
            context.SaveChanges();
        }
        public void update_companion(int id,string name,string whopayed)
        {
            var entity = context.TblCompanions.FirstOrDefault(item => item.CompanionId == id);
            if (entity != null)
            {
                if (!String.IsNullOrEmpty(name))
                {
                    entity.CompanionName = name;
                }
                if (!String.IsNullOrEmpty(whopayed))
                {
                    entity.WhoPlayed = whopayed;
                }
                context.SaveChanges();
            }
        }
        public void update_Enemy(int id, string Enemy_Name, string Description)
        {
            var entity = context.TblEnemies.FirstOrDefault(item => item.EnemyId== id);
            if (entity != null)
            {
                if (!String.IsNullOrEmpty(Enemy_Name))
                {
                    entity.EnemyName=Enemy_Name;
                }
                if (!String.IsNullOrEmpty(Description))
                {
                    entity.Description= Description;
                }
                context.SaveChanges();
            }
        }
        public void update_doctors(int id, int Doctor_Number, string Doctor_Name, DateTime ?birth, DateTime ?FirstEpisode, DateTime? LastEpisode)
        {
            var entity = context.TblDoctors.FirstOrDefault(item => item.DoctorId == id);
            if (entity != null)
            {
                if (!String.IsNullOrEmpty(Doctor_Number.ToString()))
                {
                    entity.DoctorNumber=Doctor_Number;
                }
                if (!String.IsNullOrEmpty(Doctor_Name))
                {
                    entity.DoctorName = Doctor_Name;
                }
                if (!(birth==null))
                {
                    entity.BirthDate = birth;
                }
                if (!(FirstEpisode==null))
                {
                    entity.FirstEpisodeDate= FirstEpisode;
                }
                if (!(LastEpisode==null))
                {
                    entity.LastEpisodeDate =LastEpisode ;
                }
                context.SaveChanges();
            }
        }
        public void update_authors(int id, string Author_Name)
        {
            var entity = context.TblAuthors.FirstOrDefault(item => item.AuthorId == id);
            if (entity != null)
            {
                if (!String.IsNullOrEmpty(Author_Name))
                {
                    entity.AuthorName = Author_Name;
                }

                context.SaveChanges();
            }
        }
        public void update_episode(int id, int seriesNumber, int episodenumber, string episodeType, string title, DateTime? episodeDate, int authorId, int doctorId, string notes)
        {
            var entity = context.TblEpisodes.FirstOrDefault(item => item.EpisodeId == id);
            if (entity != null)
            {
                if (!String.IsNullOrEmpty(seriesNumber.ToString()))
                {
                    entity.SeriesNumber= seriesNumber;
                }
                if (!String.IsNullOrEmpty(episodenumber.ToString()))
                {
                    entity.EpisodeNumber = episodenumber;
                }
                if (!String.IsNullOrEmpty(episodeType))
                {
                    entity.EpisodeType= episodeType;
                }
                if (!String.IsNullOrEmpty(title))
                {
                    entity.Title = title;
                }
                if (!(episodeDate== null))
                {
                    entity.EpisodeDatedate = episodeDate;
                }
                if (!String.IsNullOrEmpty(authorId.ToString()))
                {
                    entity.AuthorId = authorId;
                }
                if (!String.IsNullOrEmpty(doctorId.ToString()))
                {
                    entity.DoctorId = doctorId;
                }
                if (!String.IsNullOrEmpty(notes))
                {
                    entity.Notes= notes;
                }
                context.SaveChanges();
            }
        }

        public void Delete_Companions(int id)
        {
            var DeleteRecord1 = new TblEpisodeCompanion {CompanionId = id };
            context.TblEpisodeCompanions.Attach(DeleteRecord1);
            context.TblEpisodeCompanions.Remove(DeleteRecord1);
            context.SaveChanges();
            var DeleteRecord = new TblCompanion{ CompanionId=id };
           context.TblCompanions.Attach(DeleteRecord);
            context.TblCompanions.Remove(DeleteRecord);
            context.SaveChanges();
        }
        public void Delete_Enemy(int id)
        {
 
            var DeleteRecord = new TblEnemy { EnemyId = id };
            context.TblEnemies.Attach(DeleteRecord);
            context.TblEnemies.Remove(DeleteRecord);
            context.SaveChanges();
        }
        public void Delete_Doctor(int id)
        {
            var DeleteRecord = new TblDoctor { DoctorId = id };
            context.TblDoctors.Attach(DeleteRecord);
            context.TblDoctors.Remove(DeleteRecord);
            context.SaveChanges();
        }
        public void Delete_Author(int id)
        {
            var DeleteRecord = new TblAuthor { AuthorId= id };
            context.TblAuthors.Attach(DeleteRecord);
            context.TblAuthors.Remove(DeleteRecord);
            context.SaveChanges();
        }
        public void Delete_Episode(int id)
        {
            var DeleteRecord = new TblEpisode {EpisodeId = id };
            context.TblEpisodes.Attach(DeleteRecord);
            context.TblEpisodes.Remove(DeleteRecord);
            context.SaveChanges();
        }
        public  void AddEnemyToEpisode(int enemyid,int episodeid)
        {
            TblEpisodeEnemy obj = new TblEpisodeEnemy
            {
                EpisodeId = episodeid,
                EnemyId = enemyid 
            };
            context.Add(obj);
            context.SaveChanges();


        }
        public  void AddCompanionToEpisode(int compid,int episodeid)
        {
            TblEpisodeCompanion obj = new TblEpisodeCompanion
            {
                EpisodeId = episodeid,
               CompanionId=compid
            };
            context.Add(obj);
            context.SaveChanges();

        }

        public  void GetAllDoctors()
        {
            var doctor = context.TblDoctors.ToList();
            Console.WriteLine("-----------------Doctor Table Inforamation -------------------");
            foreach (var t in doctor)
            {
                
                Console.WriteLine($"Doctor Id:         {t.DoctorId}");
                Console.WriteLine($"Doctor Number:     {t.DoctorNumber}");
                Console.WriteLine($"Doctor Name:       {t.DoctorName}");
                Console.WriteLine($"Doctor Birthday:   {t.BirthDate}");
                Console.WriteLine($"Doctor First Date: {t.FirstEpisodeDate}");
                Console.WriteLine($"Doctor Last Date:  {t.LastEpisodeDate}");
                Console.WriteLine("--------------------------------------------------");

            }

        }
        public  void GetEnemyById(int id)
        {
             TblEnemy Enemy = context.TblEnemies.FirstOrDefault(item=>item.EnemyId==id);
            
            Console.WriteLine("-----------------Enemy Table Inforamation -------------------");
                Console.WriteLine($"Enemy Id:         {Enemy.EnemyId}");
                Console.WriteLine($"Enemy Name:     {Enemy.EnemyName}");
                Console.WriteLine($"Enemy Description:       {Enemy.Description}");
                Console.WriteLine("--------------------------------------------------");

        }
        public void GetCompanionById(int id)
        {
            TblCompanion comp= context.TblCompanions.FirstOrDefault(item => item.CompanionId == id);
           
            Console.WriteLine("-----------------Companions Table Inforamation -------------------");
            Console.WriteLine($"Companion Id:         {comp.CompanionId}");
            Console.WriteLine($"Companion Number:     {comp.CompanionName}");
            Console.WriteLine($"Who Palyed :       {comp.WhoPlayed}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
