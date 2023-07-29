using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class LocationTableService:IService<LocationTable>
    {
        public int Delete(LocationTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(LocationTable t)
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

                return db.LocationTable.Count();

            }
        }

        public LocationTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.LocationTable.FirstOrDefault(item => item.LocationID == Id);
            }
        }

        public LocationTable Select(string AthleteName)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.LocationTable.FirstOrDefault(item => item.LocationName == AthleteName);
            }
        }

        public List<LocationTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.LocationTable.ToList();

            }
        }

        public int Update(LocationTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
