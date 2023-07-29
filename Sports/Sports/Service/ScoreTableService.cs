using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class ScoreTableService:IService<ScoreTable>
    {

        public int Delete(ScoreTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(ScoreTable t)
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

                return db.ScoreTable.Count();

            }
        }

        public ScoreTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.ScoreTable.FirstOrDefault(item => item.ScoreID == Id);
            }
        }

        public ScoreTable Select(string Name)
        {
            return null;
        }

        public List<ScoreTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.ScoreTable.ToList();

            }
        }

        public int Update(ScoreTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
