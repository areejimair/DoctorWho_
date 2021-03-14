using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoctorWho.DB;
using DoctorWho.DB.Models;
namespace DoctorWho.DB.Repositories
{

    public class TblAuthorRep
    {
        public DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
        public void Create_Author(string Author_Name)
        {
            TblAuthor CreateAuthor = new TblAuthor
            {
                AuthorName = Author_Name
            };
            context.Add(CreateAuthor);
            context.SaveChanges();
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
        public void Delete_Author(int id)
        {
            var DeleteRecord = new TblAuthor { AuthorId = id };
            context.TblAuthors.Attach(DeleteRecord);
            context.TblAuthors.Remove(DeleteRecord);
            context.SaveChanges();
        }
    }
}
