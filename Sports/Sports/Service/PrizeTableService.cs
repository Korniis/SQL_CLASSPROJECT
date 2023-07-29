using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class PrizeTableService:IService<PrizeTable>
    {
        public int Delete(PrizeTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(PrizeTable t)
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

                return db.PrizeTable.Count();

            }
        }

        public PrizeTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.PrizeTable.FirstOrDefault(item => item.PrizeID == Id);
            }
        }

        public PrizeTable Select(string Name)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.PrizeTable.FirstOrDefault(item => item.PrizeName == Name);
            }
        }

        public List<PrizeTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.PrizeTable.ToList();

            }
        }

        public int Update(PrizeTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
