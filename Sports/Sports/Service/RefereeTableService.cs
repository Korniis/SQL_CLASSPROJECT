using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public  class RefereeTableService:IService<RefereeTable>
    {
        public int Delete(RefereeTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(RefereeTable t)
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

                return db.RefereeTable.Count();

            }
        }

        public RefereeTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RefereeTable.FirstOrDefault(item => item.RefereeID == Id);
            }
        }

        public RefereeTable Select(string Name)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RefereeTable.FirstOrDefault(item => item.RefereeName == Name);
            }
        }
        public RefereeTable SelectMatch(int ID)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RefereeTable.FirstOrDefault(item => item.MatchID == ID);
            }
        }


        public List<RefereeTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RefereeTable.Include("MatchTable").ToList();

            }
        }

        public int Update(RefereeTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
