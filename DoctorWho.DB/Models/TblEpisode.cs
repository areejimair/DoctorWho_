using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.DB.Models
{
    public class TblEpisode
    {
        public TblEpisode()
        {
            TblEpisodeCompanions = new HashSet<TblEpisodeCompanion>();
            TblEpisodeEnemies = new HashSet<TblEpisodeEnemy>();
        }

        [Key]
        public int EpisodeId { get; set; }
        public int? SeriesNumber { get; set; }
        public int? EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime? EpisodeDatedate { get; set; }
        public int? AuthorId { get; set; }
        public int? DoctorId { get; set; }
        public string Notes { get; set; }

        public virtual TblAuthor Author { get; set; }
        public virtual TblDoctor Doctor { get; set; }
        public virtual ICollection<TblEpisodeCompanion> TblEpisodeCompanions { get; set; }
        public virtual ICollection<TblEpisodeEnemy> TblEpisodeEnemies { get; set; }
    }
}
