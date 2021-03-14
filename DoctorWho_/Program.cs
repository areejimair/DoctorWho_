using System;
using System.Linq;
using DoctorWho.DB;
using DoctorWho.DB.Models;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DoctorWho.DB.Repositories;
using Microsoft.EntityFrameworkCore;
using DoctorWho_.methods;

namespace DoctorWho_
{
    public class Program
    {
        static void Main(string[] args)
        {
            method _method = new method();
            TblAuthorRep author = new TblAuthorRep();
            TblCompanionRep companion = new TblCompanionRep();
            TblDoctorRep doctor = new TblDoctorRep();
            TblEnemyRep enemy = new TblEnemyRep();
            TblEpisodeRep episode = new TblEpisodeRep();
            TblEpsiodeCompanionRep ep_com = new TblEpsiodeCompanionRep();
            TblEpsiodeEnemyRep ep_enemy = new TblEpsiodeEnemyRep();
            DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
            int number = 0;
            string alph = null;
            while (true)
            {
                Console.WriteLine("1-Create");
                Console.WriteLine("2-Update");
                Console.WriteLine("3-Delete");
                Console.WriteLine("4-Execute View");
                Console.WriteLine("5- Execute Procedure");
                Console.WriteLine("6- Execute fnCompaions Function");
                Console.WriteLine("7- Execute fnEnemies Function");
                Console.WriteLine("8- AddCompanionToEpisode");
                Console.WriteLine("9- AddEnemyToEpisode");
                Console.WriteLine("10- Get All Doctors");
                Console.WriteLine("11- GetCompanionById");
                Console.WriteLine("12- GetEnemyById");

                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            
                                Console.WriteLine("a-Create Companios");
                                Console.WriteLine("b-Create enemies");
                                Console.WriteLine("c-Create Doctors");
                                Console.WriteLine("d-Create Author");
                                Console.WriteLine("e-Create episode");
                                Console.WriteLine("f-exit");
                                alph = Console.ReadLine();
                                switch (alph)
                                {
                                    case "a":
                                        {
                                            Console.Write("Enter Compaions Name: ");
                                            String compName = Console.ReadLine();
                                            Console.Write("Enter Who Palyed Name: ");
                                            String WhoPalyed = Console.ReadLine();
                                            Console.WriteLine();
                                            companion.Create_Companios(compName, WhoPalyed);
                                            break;
                                        }
                                    case "b":
                                        {
                                            Console.Write("Enter Enemy Name: ");
                                            String EnemyName = Console.ReadLine();
                                            Console.Write("Enter Description: ");
                                            String Des = Console.ReadLine();
                                            Console.WriteLine();
                                            enemy.Create_Enemy(EnemyName, Des);
                                            break;
                                        }
                                    case "c":
                                        {
                                            Console.Write("Enter Doctor Number: ");
                                            int DoctorNumber = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Who Doctor Name: ");
                                            String DoctorName = Console.ReadLine();
                                            Console.Write("Enter Birth Date: ");
                                            DateTime birth = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Enter First Date Episode: ");
                                            DateTime First = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Enter Last Date Episode: ");
                                            DateTime Last = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine();
                                            doctor.Create_Doctor(DoctorNumber,DoctorName,birth,First,Last);
                                            break;
                                        }
                                    case "d":
                                        {
                                            Console.Write("Enter Author Name: ");
                                            String authName = Console.ReadLine();
                                            author.Create_Author(authName);
                                            break;
                                        }
                                    case "e":
                                        {
                                            Console.Write("Enter series Number: ");
                                            int seriesNumber = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Who epsiodeNumber: ");
                                            int epNumber = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter epsiode Type: ");
                                            string type=Console.ReadLine();
                                            Console.Write("Enter Title: ");
                                            string title = Console.ReadLine();
                                            Console.Write("Enter Episode Date: ");
                                            DateTime dateep = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Enter Author id: ");
                                            int authid = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Who doctorId: ");
                                            int doctorid = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Notes: ");
                                            string note = Console.ReadLine();
                                            Console.WriteLine();
                                            episode.Create_Episode(seriesNumber,epNumber,type,title,dateep,authid,doctorid,note);
                                            break;
                                        }
                                    case "f":
                                        {
                                            return;
                                        }
                                    default:
                                        {
                                           break;
                                        }

                                }
                            break;

                            
                        }
                    case 2:
                        {
                            Console.WriteLine("a-Update Companios");
                            Console.WriteLine("b-Update enemies");
                            Console.WriteLine("c-Update Doctors");
                            Console.WriteLine("d-Update Author");
                            Console.WriteLine("e-Update episode");
                            Console.WriteLine("f-exit");
                            alph = Console.ReadLine();
                            switch (alph)
                            {
                                case "a":
                                    {
                                        Console.Write("Enter id: ");
                                        int  id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Compaions Name: ");
                                        String  compName = Console.ReadLine();
                                        Console.Write("Enter Who Palyed Name: ");
                                        String WhoPalyed = Console.ReadLine();
                                        Console.WriteLine();
                                        companion.update_companion(id,compName, WhoPalyed);
                                        break;
                                    }
                                case "b":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Enemy Name: ");
                                        String EnemyName = Console.ReadLine();
                                        Console.Write("Enter Description: ");
                                        String Des = Console.ReadLine();
                                        Console.WriteLine();
                                        enemy.update_Enemy(id,EnemyName, Des);
                                        break;
                                    }
                                case "c":
                                    {
                                        DateTime? birth;
                                        DateTime? First;
                                        DateTime? Last;
                                        int DoctorNumber;
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Doctor Number: ");
                                        string n1 = Console.ReadLine();
                                        DoctorNumber = Convert.ToInt32(n1);
                                        Console.Write("Enter Who Doctor Name: ");
                                        String DoctorName = Console.ReadLine();
                                        Console.Write("Enter Birth Date: ");
                                        string ? v1 = Console.ReadLine();
                                        if (!(String.IsNullOrEmpty(v1)))
                                        {
                                            birth =Convert.ToDateTime(v1);
                                        }
                                        else birth = null;
                                        Console.Write("Enter First date Episode: ");
                                        string ?v2 = Console.ReadLine();
                                        if (!(String.IsNullOrEmpty(v2)))
                                        {
                                            First = Convert.ToDateTime(v2);
                                        }
                                        else First = null;
                                        Console.Write("Enter Last Date Epiosde: ");
                                        string ?v3 = Console.ReadLine();
                                        if (!(String.IsNullOrEmpty(v3)))
                                        {
                                            Last = Convert.ToDateTime(v2);
                                        }
                                        else Last = null;
                                        Console.WriteLine();
                                        doctor.update_doctors(id,DoctorNumber, DoctorName, birth, First, Last);
                                        break;
                                    }
                                case "d":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Author Name: ");
                                        String authName = Console.ReadLine();
                                        author.update_authors(id,authName);
                                        break;
                                    }
                                case "e":
                                    {
                                        DateTime ?dateep;
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter series Number: ");
                                        int seriesNumber = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Who epsiodeNumber: ");
                                        int epNumber = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter epsiode Type: ");
                                        string type = Console.ReadLine();
                                        Console.Write("Enter Title: ");
                                        string title = Console.ReadLine();
                                        Console.Write("Enter Episode Date: ");
                                        string? v1 = Console.ReadLine();
                                        if (!(String.IsNullOrEmpty(v1)))
                                        {
                                            dateep = Convert.ToDateTime(v1);
                                        }
                                        else dateep = null;
                                        Console.Write("Enter Author id: ");
                                        int authid = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Who doctorId: ");
                                        int doctorid = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Notes: ");
                                        string note = Console.ReadLine();
                                        Console.WriteLine();
                                        episode.update_episode(id,seriesNumber, epNumber, type, title, dateep, authid, doctorid, note);
                                        break;
                                    }
                                case "f":
                                    {
                                        return;
                                    }
                                default:
                                    {
                                        break;
                                    }

                            }
                            break;


                        }
                    case 3:
                        {
                            Console.WriteLine("a-Delete Companios");
                            Console.WriteLine("b-Delete enemies");
                            Console.WriteLine("c-Delete Doctors");
                            Console.WriteLine("d-Delete Author");
                            Console.WriteLine("e-Delete episode");
                            Console.WriteLine("f-exit");
                            alph = Console.ReadLine();
                            switch (alph)
                            {
                                case "a":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        
                                        companion.Delete_Companions(id);
                                        break;
                                    }
                                case "b":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        enemy.Delete_Enemy(id);
                                        break;
                                    }
                                case "c":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        doctor.Delete_Doctor(id);
                                        break;
                                    }
                                case "d":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        author.Delete_Author(id);
                                        break;
                                    }
                                case "e":
                                    {
                                        Console.Write("Enter id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        episode.Delete_Episode(id);
                                        break;
                                    }
                                case "f":
                                    {
                                        return;
                                    }
                                default:
                                    {
                                        break;
                                    }

                            }
                            break;
                        }
                    case 4:
                        {
                            context.Database.ExecuteSqlRaw("select *from [dbo].[ViewEpisodes]");
                            break;
                        }
                    case 5:
                        {
                            var pro = context.Database.ExecuteSqlRaw("EXEC [dbo].[spSummariseEpisodes]");
                            break;
                        }
                    case 6:
                        {
                            var n = context.TblCompanions.Select(s => new
                            {
                                s.CompanionName,
                                name = DoctorWhoCoreDbContext.fnCompanions(s.CompanionId)
                            });



                            break;
                        }
                    case 7:
                        {
                            var n = context.TblEnemies.Select(s => new
                            {
                                s.EnemyName,
                                name = DoctorWhoCoreDbContext.fnCompanions(s.EnemyId)
                            });
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Enter id: ");
                            int Epsiode_id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter id: ");
                            int Compa_id = Convert.ToInt32(Console.ReadLine());
                           
                             ep_com.AddCompanionToEpisode(Epsiode_id,Compa_id);
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Enter id: ");
                            int Epsiode_id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter id: ");
                            int Enemy_id = Convert.ToInt32(Console.ReadLine());

                            ep_enemy.AddEnemyToEpisode(Epsiode_id,Enemy_id);
                            break;
                        }
                    case 10:
                        {
                            doctor.GetAllDoctors();
                            break;
                        }
                    case 11:
                        {
                            Console.Write("Enter id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            companion.GetCompanionById(id);
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Enter id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            enemy.GetEnemyById(id);
                            break;
                        }


                        

                }
            }


        }

    }
}

