using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoctorWho.DB;
using DoctorWho.DB.Models;

namespace DoctorWho.DB.Repositories
{
    public class TblEpsiodeEnemyRep
    {
        public DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
        public void AddEnemyToEpisode(int enemyid, int episodeid)
        {
            TblEpisodeEnemy obj = new TblEpisodeEnemy
            {
                EpisodeId = episodeid,
                EnemyId = enemyid
            };
            context.Add(obj);
            context.SaveChanges();


        }
    }
}
