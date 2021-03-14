using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoctorWho.DB;
using DoctorWho.DB.Models;
namespace DoctorWho.DB.Repositories
{
    public class TblEpsiodeCompanionRep
    {
        public DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
        public void AddCompanionToEpisode(int compid, int episodeid)
        {
            TblEpisodeCompanion obj = new TblEpisodeCompanion
            {
                EpisodeId = episodeid,
                CompanionId = compid
            };
            context.Add(obj);
            context.SaveChanges();

        }
    }
}
