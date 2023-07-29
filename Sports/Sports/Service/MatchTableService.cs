using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class MatchTableService:IService<MatchTable>
    {
        public int Delete(MatchTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(MatchTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();


            }
        }
        public int Count()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.MatchTable.Count();

            }
        }

        public MatchTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.MatchTable.FirstOrDefault(item => item.MatchID == Id);
            }
        }

        public MatchTable Select(string MatchName)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.MatchTable.FirstOrDefault(item => item.MatchName == MatchName);
            }
        }


        public List<MatchTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.MatchTable.Include("LocationTable").ToList();

            }
        }

        public int Update(MatchTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
